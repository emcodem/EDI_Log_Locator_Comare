using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EDI_LOC_Validator
{
    public partial class Form1 : Form
    {
        private List<EdiEntry> m_newEntries = new List<EdiEntry>();
        private List<EdiEntry> m_oldEntries = new List<EdiEntry>();
        public Form1()
        {
            InitializeComponent();
        }

        public List<EdiEntry> ediToCallSignList(string path)
        {
            List<EdiEntry> list = new List<EdiEntry>();
            try
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    try
                    {
                        var split = line.Split(';');
                        if (split.Length == 15)
                        {
                            var ymd = split[0];
                            var hm = split[1];
                            var callsign = split[2];
                            var locator = split[9];
                            list.Add(new EdiEntry(callsign, locator,ymd,hm));
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            catch (Exception exc) { }

            return list;
        }

        private void buttonBrowseCurrentEdi_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            // Set validate names and check file exists to false otherwise windows will
            // not let you select "Folder Selection."
            folderBrowser.ValidateNames = true;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.Filter = "edi|*.edi";
            // Always default to Folder Selection.
            //folderBrowser.FileName = "Select Current Folder.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                    textBoxCurrentEdi.Text = folderBrowser.FileName;
                    parseEdiLogFromFile();
                }
                catch (Exception ex) {
                    MessageBox.Show("Error reading edi log: " + ex);
                }
            }
        }
        private void textBoxCurrentEdi_TextChanged(object sender, EventArgs e)
        {
            parseEdiLogFromFile();
        }
        private void parseEdiLogFromFile() {
            m_newEntries.Clear();
            m_newEntries = ediToCallSignList(textBoxCurrentEdi.Text);
            labelNewEntryCount.Text = "Count: " + m_newEntries.Count;
            compareOldNew();
        }

        private void parseEdiLogsFromFolder(string root)
        {
            DirectoryInfo d = new DirectoryInfo(root); //Assuming Test is your Folder

            FileInfo[] Files = d.GetFiles("*.edi"); //Getting Text files
            string str = "";

            m_oldEntries.Clear();

            foreach (FileInfo file in Files)
            {
                m_oldEntries.AddRange(ediToCallSignList(file.FullName));
            }

            labelOldLogCount.Text = "Count: " + m_oldEntries.Count.ToString();

        }

        private void buttonBrowseOldEdi_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            // Set validate names and check file exists to false otherwise windows will
            // not let you select "Folder Selection."
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            // Always default to Folder Selection.
            folderBrowser.FileName = "Select Current Folder.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                textBoxOldEdiLogPath.Text = folderPath;
                parseEdiLogsFromFolder(folderPath);
                compareOldNew();
            }
        }

        private void compareOldNew() {

            //dataGridViewEntriesDifferent.DataSource = m_allEntries.Where(x => x.CALL.Contains(callsign)).ToList().GroupBy(x => x.LOC).Select(x => x.First()).ToList();
            //step through all entries of new list and check if any callsigns have not yet seen locator

            //LOCATORS - check by callsign if we have a different locator than in history
            List<EdiEntry> newEntriesWithOddLoc = new List<EdiEntry>();

            for (int i = 0; i < m_newEntries.Count; i++)
            {
                EdiEntry currentEntry = m_newEntries[i];
                List<EdiEntry> allOldEntriesWithSameCallsign = m_oldEntries.FindAll(p => p.CALL == currentEntry.CALL);
                var anyOldLocatorMatches = false;
                foreach(var en in allOldEntriesWithSameCallsign)
                {
                    if (currentEntry.LOC == en.LOC) {
                        anyOldLocatorMatches = true;
                    }
                }
                if (!anyOldLocatorMatches && allOldEntriesWithSameCallsign.Count != 0) {
                    newEntriesWithOddLoc.Add(currentEntry);
                }
            }
            dataGridViewEntriesDifferent.DataSource = null;
            dataGridViewEntriesDifferent.DataSource = newEntriesWithOddLoc;


            //CALLSIGNS - check by locator if callsign is different
            List<EdiEntry> newEntriesWithOddCall = new List<EdiEntry>();
            for (int i = 0; i < m_newEntries.Count; i++)
            {
                EdiEntry currentEntry = m_newEntries[i];
                List<EdiEntry> allOldEntriesWithSameLocator = m_oldEntries.FindAll(p => p.LOC == currentEntry.LOC);
                var any_old_call_matches = false;
                foreach (var en in allOldEntriesWithSameLocator)
                {
                    if (currentEntry.CALL == en.CALL)
                    {
                        any_old_call_matches = true;
                    }
                }
                if (!any_old_call_matches && allOldEntriesWithSameLocator.Count != 0)
                {
                    newEntriesWithOddCall.Add(currentEntry);
                }
            }
            dataGridViewOddCallsigns.DataSource = null;
            dataGridViewOddCallsigns.DataSource = newEntriesWithOddCall;

        }

        private void dataGridViewEntriesDifferent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewEntriesDifferent_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCall = dataGridViewEntriesDifferent.Rows[e.RowIndex].Cells[0].Value.ToString();
            var selectedLoc = dataGridViewEntriesDifferent.Rows[e.RowIndex].Cells[1].Value.ToString();
            List<EdiEntry> knownEntries = m_oldEntries.FindAll(p => p.CALL == selectedCall);
            dataGridViewHistoryLoc.DataSource = null;
            dataGridViewHistoryLoc.DataSource = knownEntries;
        }

        private void buttonUpdateLoc_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntriesDifferent.SelectedCells.Count == 0) { 
                MessageBox.Show("No entry selected in left Datagrid");
                return;
            }
            try { 
                var idxleft  = dataGridViewEntriesDifferent.SelectedCells[0].RowIndex;
                var idxRight = dataGridViewHistoryLoc.SelectedCells[0].RowIndex;
                var callSign   = dataGridViewEntriesDifferent.Rows[idxleft].Cells[0].Value.ToString();
                var oldLocator = dataGridViewEntriesDifferent.Rows[idxleft].Cells[1].Value.ToString();
                var newLocator = dataGridViewHistoryLoc.Rows[idxRight].Cells[1].Value.ToString();
                var yes = MessageBox.Show("Update " + callSign + " with Locator " + newLocator + "?","Update", System.Windows.Forms.MessageBoxButtons.YesNo);
                if (yes != System.Windows.Forms.DialogResult.Yes)
                    return;
                executeLocatorUpdate(callSign, oldLocator, newLocator);
            }catch(Exception ex)
            {
                MessageBox.Show("Unexpected error, make sure some cell is selected left and right."); return;
            }
        }

        private void executeLocatorUpdate(string call, string oldloc, string newloc)
        {
            if (oldloc.Length != 6 || newloc.Length != 6) {
                MessageBox.Show("Cannot update entry because old or new Locator was not exactly 6 chars long (old: " + oldloc + "), (new: " + newloc + ")");
                return;
            }
            try { 
                string fulltext = File.ReadAllText(textBoxCurrentEdi.Text);
                int matchesfound = 0;
                int lineindex = 0;
                Regex rg = new Regex("(" + oldloc + ")");
                
                Match matchresult = rg.Match(fulltext);
                if (matchresult.Groups.Count == 0) {
                    MessageBox.Show("Cannot update entry because " + oldloc + " was not found in EDI log: " + textBoxCurrentEdi.Text);
                    return;
                }
                if (matchresult.Groups.Count > 2) {//first group is fullmatch, second and following capture group
                    MessageBox.Show("Cannot update entry because " + oldloc + " was found multiple times (" + (matchresult.Groups.Count-1) + ")");
                    return;
                }
                if (matchresult.Value != oldloc) {
                    MessageBox.Show("Cannot update entry because old locator was not found in EDI log, this should not happen and is most likely an internal program error");
                    return;
                }

                //make backup of current EDI
                File.WriteAllText(textBoxCurrentEdi.Text + "_backup_" + oldloc + "_" + newloc, fulltext);
                fulltext = fulltext.Replace(oldloc, newloc);
                File.WriteAllText(textBoxCurrentEdi.Text, fulltext);
                dataGridViewHistoryLoc.DataSource = null;
                parseEdiLogFromFile();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Unexpected Errror updating edi: " + ex);
            }
        }

        private void dataGridViewOddCallsigns_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewOddCallsigns_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            var selectedCall = dataGridViewOddCallsigns.Rows[e.RowIndex].Cells[0].Value.ToString();
            var selectedLoc = dataGridViewOddCallsigns.Rows[e.RowIndex].Cells[1].Value.ToString();
            List<EdiEntry> knownEntries = m_oldEntries.FindAll(p => p.LOC == selectedLoc);
            dataGridViewKnownCallsigns.DataSource = null;
            dataGridViewKnownCallsigns.DataSource = knownEntries;
        }
        private void buttonUpdateCall_Click(object sender, EventArgs e)
        {
            if (dataGridViewKnownCallsigns.SelectedCells.Count == 0)
            {
                MessageBox.Show("No entry selected in right Datagrid");
                return;
            }
            var idxleft = dataGridViewOddCallsigns.SelectedCells[0].RowIndex;
            var idxRight = dataGridViewKnownCallsigns.SelectedCells[0].RowIndex;
            var locator = dataGridViewOddCallsigns.Rows[idxleft].Cells[1].Value.ToString();
            var oldCall = dataGridViewOddCallsigns.Rows[idxleft].Cells[0].Value.ToString();
            var newCall = dataGridViewKnownCallsigns.Rows[idxRight].Cells[0].Value.ToString();
            var yes = MessageBox.Show("Update Callsign " + oldCall + " with Callsign " + newCall + "?","Update", System.Windows.Forms.MessageBoxButtons.YesNo);
            if (yes != System.Windows.Forms.DialogResult.Yes)
                return;
            executeCallsignUpdate(locator, oldCall, newCall);
            
        }

        private void executeCallsignUpdate(string call, string oldCall = "", string newCall = "")
        {
            if (oldCall.Length == 0 || oldCall.Length == 0)
            {
                MessageBox.Show("Cannot update entry because old or new Locator was of length zero (old: " + oldCall + "), (new: " + newCall + ")");
                return;
            }
            try
            {
                string fulltext = File.ReadAllText(textBoxCurrentEdi.Text);
                int matchesfound = 0;
                int lineindex = 0;
                Regex rg = new Regex("(" + oldCall + ")");

                Match matchresult = rg.Match(fulltext);
                if (matchresult.Groups.Count == 0)
                {
                    MessageBox.Show("Cannot update entry because " + oldCall + " was not found in EDI log: " + textBoxCurrentEdi.Text);
                    return;
                }
                if (matchresult.Groups.Count > 2)
                {//first group is fullmatch, second and following capture group
                    MessageBox.Show("Cannot update entry because " + oldCall + " was found multiple times (" + (matchresult.Groups.Count - 1) + ")");
                    return;
                }
                if (matchresult.Value != oldCall)
                {
                    MessageBox.Show("Cannot update entry because old CALL was not found in EDI log, this should not happen and is most likely an internal program error");
                    return;
                }

                //make backup of current EDI
                File.WriteAllText(textBoxCurrentEdi.Text + "_backup_ " + oldCall + "_" + newCall, fulltext);
                fulltext = fulltext.Replace(oldCall, newCall);
                File.WriteAllText(textBoxCurrentEdi.Text, fulltext);
                dataGridViewKnownCallsigns.DataSource = null;
                parseEdiLogFromFile();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Errror updating edi: " + ex);
            }
        }


    }

    public class EdiEntry
    {
        private string _CALL;
        private string _LOC;
        private string _YMD;
        private string _HM;
        public string CALL { get { return _CALL; } }
        public string LOC { get { return _LOC; } }

        public string TIME { get { return _HM; } }
        public EdiEntry(string call, string loc, string ymd, string hm) //ymdhm is time
        {
            _CALL = call;
            _LOC = loc;
            _YMD = ymd;
            _HM = hm;
        }


    }
}
