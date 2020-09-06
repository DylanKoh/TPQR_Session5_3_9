using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPQR_Session5_3_9
{
    public partial class AssignSeat : Form
    {
        int getSkillID = 0;
        public AssignSeat()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            (new AdminMain()).ShowDialog();
            Close();
        }

        private void AssignSeat_Load(object sender, EventArgs e)
        {
            using (var context = new Session5Entities())
            {
                var getSkills = (from x in context.Skills
                                 select x.skillName).Distinct().ToArray();
                cbSkill.Items.AddRange(getSkills);
            }
        }

        private void cbSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new Session5Entities())
            {
                getSkillID = (from x in context.Skills
                              where x.skillName == cbSkill.SelectedItem.ToString()
                              select x.skillId).FirstOrDefault();
            }
            LoadSeats();
            LoadCompetitors();
        }

        private void LoadCompetitors()
        {
            lbCompetitors.Items.Clear();
            using (var context = new Session5Entities())
            {
                var getUCompetitors = (from x in context.Competitors
                                       where x.skillIdFK == getSkillID && x.assignedSeat == 0
                                       select x);
                lblUnassigned.Text = getUCompetitors.Count().ToString();
                foreach (var item in getUCompetitors)
                {
                    lbCompetitors.Items.Add($"{item.competitorName}, {item.competitorCountry}");
                }
                var getACompetitors = (from x in context.Competitors
                                       where x.skillIdFK == getSkillID && x.assignedSeat != 0
                                       select x);
                lblAssigned.Text = getACompetitors.Count().ToString();
                foreach (var item in getACompetitors)
                {
                    var boolCheck = false;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewColumn cell in dataGridView1.Columns)
                        {
                            if (dataGridView1[cell.Index, row.Index].Value.ToString() == item.assignedSeat.ToString())
                            {
                                dataGridView1[cell.Index, row.Index].Value = $"{dataGridView1[cell.Index, row.Index].Value}\n{item.competitorId}";
                                dataGridView1[cell.Index, row.Index].Style.BackColor = Color.Blue;
                                dataGridView1[cell.Index, row.Index].Style.ForeColor = Color.White;
                                boolCheck = true;
                            }
                            if (boolCheck == true)
                            {
                                break;
                            }
                        }
                        if (boolCheck == true)
                        {
                            break;
                        }
                    }
                    if (boolCheck == true)
                    {
                        continue;
                    }
                }
            }
        }

        private void LoadSeats()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnHeadersVisible = false;
            using (var context = new Session5Entities())
            {

                var getNumberOfCompetitors = (from x in context.Skills
                                              where x.skillId == getSkillID
                                              select x.noOfCompetitors).FirstOrDefault();
                var numberRows = 0;
                if (getNumberOfCompetitors % 2 == 0)
                {
                    numberRows = getNumberOfCompetitors / 2;
                }
                else
                {
                    numberRows = (getNumberOfCompetitors / 2) + 1;
                }

                var seatC1 = 1;
                var seatC2 = 2;
                for (int i = 1; i <= numberRows; i++)
                {
                    var newRow = new List<string>() { seatC1.ToString(), seatC2.ToString() };
                    dataGridView1.Rows.Add(newRow.ToArray());
                    seatC1 += 2;
                    seatC2 += 2;
                }
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count != 2 && (dataGridView1.SelectedCells[0].Style.BackColor != Color.Blue || dataGridView1.SelectedCells[1].Style.BackColor != Color.Blue))
            {
                MessageBox.Show("Please ensure there are two competitors' seats selected!", "Invalid Input", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else
            {
                var list = new List<DataGridViewCell>();
                var valueList = new List<string>();
                foreach (DataGridViewCell item in dataGridView1.SelectedCells)
                {
                    list.Add(item);
                    valueList.Add(item.Value.ToString().Split('\n')[1]);
                }
                var boolCheck = true;
                var seat1 = 0;
                var seat2 = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (i == 0)
                    {
                        var checkNewPos = list[i + 1];
                        var currentPos = list[i];
                        var getRowIndex = checkNewPos.RowIndex;
                        var getCurrentAssignedID = currentPos.Value.ToString().Split('\n')[1];
                        using (var context = new Session5Entities())
                        {
                            seat1 = int.Parse(checkNewPos.Value.ToString().Split('\n')[0]);
                            var getCurrentCountry = (from x in context.Competitors
                                                     where x.competitorId == getCurrentAssignedID
                                                     select x.competitorCountry).FirstOrDefault();
                            if (getRowIndex == dataGridView1.RowCount - 1)
                            {
                                var getAboveCountry = dataGridView1[checkNewPos.ColumnIndex, getRowIndex - 1].Value.ToString();
                                var checkAbove = (from x in context.Competitors
                                                  where getAboveCountry.Contains(x.competitorId)
                                                  select x.competitorCountry).FirstOrDefault();

                                if (getCurrentCountry == checkAbove)
                                {
                                    boolCheck = false;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else if (getRowIndex == 0)
                            {
                                var getBottomCountry = dataGridView1[checkNewPos.ColumnIndex, getRowIndex + 1].Value.ToString();
                                var checkBottom = (from x in context.Competitors
                                                   where getBottomCountry.Contains(x.competitorId)
                                                   select x.competitorCountry).FirstOrDefault();
                                if (getCurrentCountry == checkBottom)
                                {
                                    boolCheck = false;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                var getBottomCountry = dataGridView1[checkNewPos.ColumnIndex, getRowIndex + 1].Value.ToString();
                                var getAboveCountry = dataGridView1[checkNewPos.ColumnIndex, getRowIndex - 1].Value.ToString();
                                var checkBottom = (from x in context.Competitors
                                                   where getBottomCountry.Contains(x.competitorId)
                                                   select x.competitorCountry).FirstOrDefault();
                                var checkAbove = (from x in context.Competitors
                                                  where getAboveCountry.Contains(x.competitorId)
                                                  select x.competitorCountry).FirstOrDefault();
                                if (getCurrentCountry == checkBottom || getCurrentCountry == checkAbove)
                                {
                                    boolCheck = false;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                    else
                    {
                        var checkNewPos = list[i - 1];
                        var currentPos = list[i];
                        var getRowIndex = checkNewPos.RowIndex;
                        var getCurrentAssignedID = currentPos.Value.ToString().Split('\n')[1];
                        using (var context = new Session5Entities())
                        {
                            seat2 = int.Parse(checkNewPos.Value.ToString().Split('\n')[0]);
                            var getCurrentCountry = (from x in context.Competitors
                                                     where x.competitorId == getCurrentAssignedID
                                                     select x.competitorCountry).FirstOrDefault();
                            if (getRowIndex == dataGridView1.RowCount - 1)
                            {
                                var getAboveCountry = dataGridView1[checkNewPos.ColumnIndex, getRowIndex - 1].Value.ToString();
                                var checkAbove = (from x in context.Competitors
                                                  where getAboveCountry.Contains(x.competitorId)
                                                  select x.competitorCountry).FirstOrDefault();

                                if (getCurrentCountry == checkAbove)
                                {
                                    boolCheck = false;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else if (getRowIndex == 0)
                            {
                                var getBottomCountry = dataGridView1[checkNewPos.ColumnIndex, getRowIndex + 1].Value.ToString();
                                var checkBottom = (from x in context.Competitors
                                                   where getBottomCountry.Contains(x.competitorId)
                                                   select x.competitorCountry).FirstOrDefault();
                                if (getCurrentCountry == checkBottom)
                                {
                                    boolCheck = false;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                var getBottomCountry = dataGridView1[checkNewPos.ColumnIndex, getRowIndex + 1].Value.ToString();
                                var getAboveCountry = dataGridView1[checkNewPos.ColumnIndex, getRowIndex - 1].Value.ToString();
                                var checkBottom = (from x in context.Competitors
                                                   where getBottomCountry.Contains(x.competitorId)
                                                   select x.competitorCountry).FirstOrDefault();
                                var checkAbove = (from x in context.Competitors
                                                  where getAboveCountry.Contains(x.competitorId)
                                                  select x.competitorCountry).FirstOrDefault();
                                if (getCurrentCountry == checkBottom || getCurrentCountry == checkAbove)
                                {
                                    boolCheck = false;
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }
                if (boolCheck == false)
                {
                    MessageBox.Show("Unable to swap seats as Competitors of same country cannot be in front or behind each other!",
                        "Invalid seating assignment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i == 0)
                        {
                            var newPos = list[i + 1];
                            var curretID = valueList[i];
                            dataGridView1[newPos.ColumnIndex, newPos.RowIndex].Value = $"{seat1}\n{curretID}";
                        }
                        else
                        {
                            var newPos = list[i - 1];
                            var curretID = valueList[i];
                            dataGridView1[newPos.ColumnIndex, newPos.RowIndex].Value = $"{seat2}\n{curretID}";
                        }
                    }
                }
            }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null || lbCompetitors.SelectedItem == null)
            {
                MessageBox.Show("Please ensure that a seat and a competitor have been selected!", "Invalid Input", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                var getCurrentRowIndex = dataGridView1.CurrentCell.RowIndex;
                using (var context = new Session5Entities())
                {
                    var getSeatNumber = dataGridView1.CurrentCell.Value.ToString();
                    var getSelectedCountry = (from x in context.Competitors
                                              where lbCompetitors.SelectedItem.ToString().Contains(x.competitorName + ", " + x.competitorCountry)
                                              select x.competitorCountry).FirstOrDefault();
                    var getSelectedID = (from x in context.Competitors
                                         where lbCompetitors.SelectedItem.ToString().Contains(x.competitorName + ", " + x.competitorCountry)
                                         select x.competitorId).FirstOrDefault();
                    if (getCurrentRowIndex == dataGridView1.RowCount - 1)
                    {
                        var getAboveCountry = dataGridView1[dataGridView1.CurrentCell.ColumnIndex, getCurrentRowIndex - 1].Value.ToString();
                        var checkAbove = (from x in context.Competitors
                                          where getAboveCountry.Contains(x.competitorId)
                                          select x.competitorCountry).FirstOrDefault();

                        if (getSelectedCountry == checkAbove)
                        {
                            MessageBox.Show("Competitors of same country cannot be in front or behind each other!",
                                "Invalid seating assignment", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else if (dataGridView1.CurrentCell.Style.BackColor == Color.Blue)
                        {
                            var getSeatNumber1 = dataGridView1.CurrentCell.Value.ToString().Split('\n')[0];
                            var getCurrentAssignedID = dataGridView1.CurrentCell.Value.ToString().Split('\n')[1];
                            var getCompetitor = (from x in context.Competitors
                                                 where x.competitorId == getCurrentAssignedID
                                                 select x).FirstOrDefault();
                            lbCompetitors.Items.Add($"{getCompetitor.competitorName}, {getCompetitor.competitorCountry}");
                            dataGridView1.CurrentCell.Value = $"{getSeatNumber1}\n{getSelectedID}";
                            lbCompetitors.Items.Remove(lbCompetitors.SelectedItem.ToString());

                        }
                        else
                        {
                            dataGridView1.CurrentCell.Value = $"{getSeatNumber}\n{getSelectedID}";
                            lbCompetitors.Items.Remove(lbCompetitors.SelectedItem.ToString());
                            dataGridView1.CurrentCell.Style.BackColor = Color.Blue;
                            dataGridView1.CurrentCell.Style.ForeColor = Color.White;
                            lblAssigned.Text = (int.Parse(lblAssigned.Text) + 1).ToString();
                            lblUnassigned.Text = (int.Parse(lblUnassigned.Text) - 1).ToString();
                        }
                    }
                    else if (getCurrentRowIndex == 0)
                    {
                        var getBottomCountry = dataGridView1[dataGridView1.CurrentCell.ColumnIndex, getCurrentRowIndex + 1].Value.ToString();
                        var checkBottom = (from x in context.Competitors
                                           where getBottomCountry.Contains(x.competitorId)
                                           select x.competitorCountry).FirstOrDefault();
                        if (getSelectedCountry == checkBottom)
                        {
                            MessageBox.Show("Competitors of same country cannot be in front or behind each other!",
                                "Invalid seating assignment", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else if (dataGridView1.CurrentCell.Style.BackColor == Color.Blue)
                        {
                            var getSeatNumber1 = dataGridView1.CurrentCell.Value.ToString().Split('\n')[0];
                            var getCurrentAssignedID = dataGridView1.CurrentCell.Value.ToString().Split('\n')[1];
                            var getCompetitor = (from x in context.Competitors
                                                 where x.competitorId == getCurrentAssignedID
                                                 select x).FirstOrDefault();
                            lbCompetitors.Items.Add($"{getCompetitor.competitorName}, {getCompetitor.competitorCountry}");
                            dataGridView1.CurrentCell.Value = $"{getSeatNumber1}\n{getSelectedID}";
                            lbCompetitors.Items.Remove(lbCompetitors.SelectedItem.ToString());

                        }
                        else
                        {
                            dataGridView1.CurrentCell.Value = $"{getSeatNumber}\n{getSelectedID}";
                            lbCompetitors.Items.Remove(lbCompetitors.SelectedItem.ToString());
                            dataGridView1.CurrentCell.Style.BackColor = Color.Blue;
                            dataGridView1.CurrentCell.Style.ForeColor = Color.White;
                            lblAssigned.Text = (int.Parse(lblAssigned.Text) + 1).ToString();
                            lblUnassigned.Text = (int.Parse(lblUnassigned.Text) - 1).ToString();
                        }
                    }
                    else
                    {
                        var getBottomCountry = dataGridView1[dataGridView1.CurrentCell.ColumnIndex, getCurrentRowIndex + 1].Value.ToString();
                        var getAboveCountry = dataGridView1[dataGridView1.CurrentCell.ColumnIndex, getCurrentRowIndex - 1].Value.ToString();
                        var checkBottom = (from x in context.Competitors
                                           where getBottomCountry.Contains(x.competitorId)
                                           select x.competitorCountry).FirstOrDefault();
                        var checkAbove = (from x in context.Competitors
                                          where getAboveCountry.Contains(x.competitorId)
                                          select x.competitorCountry).FirstOrDefault();
                        if (getSelectedCountry == checkBottom || getSelectedCountry == checkAbove)
                        {
                            MessageBox.Show("Competitors of same country cannot be in front or behind each other!",
                                "Invalid seating assignment", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else if (dataGridView1.CurrentCell.Style.BackColor == Color.Blue)
                        {
                            var getSeatNumber1 = dataGridView1.CurrentCell.Value.ToString().Split('\n')[0];
                            var getCurrentAssignedID = dataGridView1.CurrentCell.Value.ToString().Split('\n')[1];
                            var getCompetitor = (from x in context.Competitors
                                                 where x.competitorId == getCurrentAssignedID
                                                 select x).FirstOrDefault();
                            lbCompetitors.Items.Add($"{getCompetitor.competitorName}, {getCompetitor.competitorCountry}");
                            dataGridView1.CurrentCell.Value = $"{getSeatNumber1}\n{getSelectedID}";
                            lbCompetitors.Items.Remove(lbCompetitors.SelectedItem.ToString());

                        }
                        else
                        {
                            dataGridView1.CurrentCell.Value = $"{getSeatNumber}\n{getSelectedID}";
                            lbCompetitors.Items.Remove(lbCompetitors.SelectedItem.ToString());
                            dataGridView1.CurrentCell.Style.BackColor = Color.Blue;
                            dataGridView1.CurrentCell.Style.ForeColor = Color.White;
                            lblAssigned.Text = (int.Parse(lblAssigned.Text) + 1).ToString();
                            lblUnassigned.Text = (int.Parse(lblUnassigned.Text) - 1).ToString();
                        }
                    }
                }

            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var boolCheck = random();
            if (boolCheck == false)
            {
                random();
            }
        }

        private bool random()
        {
            Random random = new Random();
            var unAssignedList = new List<int>();
            var listToRemove = new List<string>();
            using (var context = new Session5Entities())
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewColumn cell in dataGridView1.Columns)
                    {
                        if (dataGridView1[cell.Index, row.Index].Style.BackColor != Color.Blue)
                        {
                            unAssignedList.Add(Convert.ToInt32(dataGridView1[cell.Index, row.Index].Value));
                        }
                    }
                }
                foreach (var item in lbCompetitors.Items)
                {
                    var getID = (from x in context.Competitors
                                 where item.ToString().Contains(x.competitorName + ", " + x.competitorCountry)
                                 select x.competitorId).FirstOrDefault();
                    var getCurrentCountry = (from x in context.Competitors
                                             where x.competitorId == getID
                                             select x.competitorCountry).FirstOrDefault();
                    var randomIndex = random.Next(unAssignedList.Count - 1);
                    var randomSeat = unAssignedList[randomIndex].ToString();
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewColumn cell in dataGridView1.Columns)
                        {
                            if (dataGridView1[cell.Index, row.Index].Value.ToString() == randomSeat)
                            {
                                var getRowIndex = row.Index;
                                if (getRowIndex == 0)
                                {
                                    var getBelowCountry = dataGridView1[cell.Index, row.Index + 1].Value.ToString();
                                    var checkBottom = (from x in context.Competitors
                                                       where getBelowCountry.Contains(x.competitorId)
                                                       select x.competitorCountry).FirstOrDefault();

                                    if (getCurrentCountry != checkBottom)
                                    {
                                        dataGridView1[cell.Index, row.Index].Value = $"{randomSeat}\n{getID}";
                                        listToRemove.Add(item.ToString());
                                        dataGridView1[cell.Index, row.Index].Style.BackColor = Color.Blue;
                                        dataGridView1[cell.Index, row.Index].Style.ForeColor = Color.White;
                                        lblAssigned.Text = (int.Parse(lblAssigned.Text) + 1).ToString();
                                        lblUnassigned.Text = (int.Parse(lblUnassigned.Text) - 1).ToString();
                                    }
                                }
                                else if (getRowIndex == dataGridView1.RowCount - 1)
                                {
                                    var getAboveCountry = dataGridView1[cell.Index, row.Index - 1].Value.ToString();
                                    var checkAbove = (from x in context.Competitors
                                                      where getAboveCountry.Contains(x.competitorId)
                                                      select x.competitorCountry).FirstOrDefault();

                                    if (getCurrentCountry != checkAbove)
                                    {
                                        dataGridView1[cell.Index, row.Index].Value = $"{randomSeat}\n{getID}";
                                        listToRemove.Add(item.ToString());
                                        dataGridView1[cell.Index, row.Index].Style.BackColor = Color.Blue;
                                        dataGridView1[cell.Index, row.Index].Style.ForeColor = Color.White;
                                        lblAssigned.Text = (int.Parse(lblAssigned.Text) + 1).ToString();
                                        lblUnassigned.Text = (int.Parse(lblUnassigned.Text) - 1).ToString();
                                    }
                                }
                                else
                                {
                                    var getAboveCountry = dataGridView1[cell.Index, row.Index - 1].Value.ToString();
                                    var checkAbove = (from x in context.Competitors
                                                      where getAboveCountry.Contains(x.competitorId)
                                                      select x.competitorCountry).FirstOrDefault();

                                    var getBelowCountry = dataGridView1[cell.Index, row.Index + 1].Value.ToString();
                                    var checkBottom = (from x in context.Competitors
                                                       where getBelowCountry.Contains(x.competitorId)
                                                       select x.competitorCountry).FirstOrDefault();

                                    if (getCurrentCountry != checkAbove && getCurrentCountry != checkBottom)
                                    {
                                        dataGridView1[cell.Index, row.Index].Value = $"{randomSeat}\n{getID}";
                                        listToRemove.Add(item.ToString());
                                        dataGridView1[cell.Index, row.Index].Style.BackColor = Color.Blue;
                                        dataGridView1[cell.Index, row.Index].Style.ForeColor = Color.White;
                                        lblAssigned.Text = (int.Parse(lblAssigned.Text) + 1).ToString();
                                        lblUnassigned.Text = (int.Parse(lblUnassigned.Text) - 1).ToString();
                                    }
                                }
                            }
                        }
                    }
                }
                foreach (var item in listToRemove)
                {
                    lbCompetitors.Items.Remove(item);
                }
            }
            if (lbCompetitors.Items.Count != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (var context = new Session5Entities())
            {
                var getSkillID = (from x in context.Skills
                                  where x.skillName == cbSkill.SelectedItem.ToString()
                                  select x.skillId).FirstOrDefault();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewColumn cell in dataGridView1.Columns)
                    {
                        if (dataGridView1[cell.Index, row.Index].Style.BackColor != Color.Blue)
                        {
                            continue;
                        }
                        else
                        {
                            var getSeat = int.Parse(dataGridView1[cell.Index, row.Index].Value.ToString().Split('\n')[0]);
                            var getID = dataGridView1[cell.Index, row.Index].Value.ToString().Split('\n')[1];

                            var getCompetitor = (from x in context.Competitors
                                                 where x.competitorId == getID && x.skillIdFK == getSkillID
                                                 select x).FirstOrDefault();
                            getCompetitor.assignedSeat = getSeat;
                            

                        }
                    }
                }
                context.SaveChanges();
            }
            MessageBox.Show("Assign seats successful!", "Assign seat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            (new AdminMain()).ShowDialog();
            Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            using (var context = new Session5Entities())
            {
                var value = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                var getNameAndCountry = (from x in context.Competitors
                                         where value.Contains(x.competitorId) && x.Skill.skillName == cbSkill.SelectedItem.ToString()
                                         select new { Name = x.competitorName, Country = x.competitorCountry }).FirstOrDefault();
                if (getNameAndCountry != null)
                {
                    dataGridView1[e.ColumnIndex, e.RowIndex].ToolTipText = $"{getNameAndCountry.Name}, {getNameAndCountry.Country}";
                }

            }
        }
    }
}
