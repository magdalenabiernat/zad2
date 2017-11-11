using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2_wzór_2017_2
{
    public partial class FormHorses : Form
    {
        List<Horse> listOfHorses;
        List<SuperHorse> listOfSuperHorses;
        List<Racehorse> listOfRaceHorse;
        public FormHorses()
        {
            InitializeComponent();
            listOfHorses = new List<Horse>();
            listOfSuperHorses = new List<SuperHorse>();
            listOfRaceHorse = new List<Racehorse>();
        }

        private void buttonAddHorse_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxHorseName.Text;
                string color = textBoxColor.Text;
                bool isFlying = checkBoxIsFlying.Checked;
                Horse horse = new Horse(name, color, isFlying);
                horse.HorseName = textBoxHorseName.Text;
                horse.Color = textBoxColor.Text;
                horse.IsFlying = checkBoxIsFlying.Checked;
                listOfHorses.Add(horse);
            }
            catch (Exception x)
            {
                MessageBox.Show("Podaj wszystkie potrzebne informacje lub we właściwym formacie");
            }
        }

        private void showHorsesList()
        {
            textBoxListOfHorses.Text = "";
            for (int i = 0; i < listOfHorses.Count; i++)
            {
                textBoxListOfHorses.Text += "* " + listOfHorses[i].HorseName + " ma kolor " + listOfHorses[i].Color + Environment.NewLine;
            }
        }

        private void buttonShowHorses_Click(object sender, EventArgs e)
        {
            showHorsesList();
        }

    

        private void buttonAddSuperHorse_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxHorseName.Text;
                string color = textBoxColor.Text;
                bool isFlying = checkBoxIsFlying.Checked;
                bool corner = checkBoxCorner.Checked;
                int prize = Int32.Parse(textBoxPrize.Text);
                SuperHorse superHorse = new SuperHorse(name, color, isFlying, corner);
                superHorse.HorseName = textBoxHorseName.Text;
                superHorse.Color = textBoxColor.Text;
                superHorse.IsFlying = checkBoxIsFlying.Checked;
                superHorse.Corner = checkBoxCorner.Checked;
                listOfSuperHorses.Add(superHorse);
            }
            catch (Exception x)
            {
                MessageBox.Show("Podaj wszystkie potrzebne informacje lub we właściwym formacie");
            }
        }
        private void showSuperHorsesList()
        {
          
            textBoxListOfHorses.Text = "";
            for (int i = 0; i < listOfSuperHorses.Count; i++)
            {
                if (listOfSuperHorses[i].Corner)
                    textBoxListOfHorses.Text += "* " + listOfSuperHorses[i].HorseName + ", ma kolor " + listOfSuperHorses[i].Color + " i ma róg" + Environment.NewLine;
                else
                    textBoxListOfHorses.Text += "* " + listOfSuperHorses[i].HorseName + ", ma kolor " + listOfSuperHorses[i].Color + " i nie ma rogu" + Environment.NewLine;

            }
        }

        private void buttonShowSuperHorse_Click(object sender, EventArgs e)
        {
            showSuperHorsesList();
        }
        private void RefreshDataGridView()
        {
            dataGridViewHorses.DataSource = null;
            dataGridViewHorses.DataSource = listOfRaceHorse;
        }

        private void buttonAddRacehorse_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxHorseName.Text;
                string color = textBoxColor.Text;
                bool corner = checkBoxCorner.Checked;
                int prize = Int32.Parse(textBoxPrize.Text);
                Racehorse racehorse = new Racehorse(name, color, corner, prize);
                racehorse.HorseName = textBoxHorseName.Text;
                racehorse.Color = textBoxColor.Text;
                racehorse.Corner = checkBoxCorner.Checked;
                racehorse.Prize = Int32.Parse(textBoxPrize.Text);
                listOfRaceHorse.Add(racehorse);
                RefreshDataGridView();
            }
            catch (Exception x)
            {
                MessageBox.Show("Podaj wszystkie potrzebne informacje lub we właściwym formacie");
            }
        }

        private void buttonRemoveRacehorse_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridViewHorses.SelectedRows[0].Index;
                listOfRaceHorse.RemoveAt(index);
                RefreshDataGridView();
            }
            catch (Exception x)
            {
                MessageBox.Show("Najpierw zaznacz konia, którego chcesz usunąć!!!");
            }
        }

        private void buttonSumPrize_Click(object sender, EventArgs e)
        {
            double sum = 0;

            foreach (Racehorse racehorse in listOfRaceHorse)
            {
                sum += racehorse.Prize;
            }
            labelSum.Text = "";
            labelSum.Visible = true;
            labelSum.Text += "suma nagród wynosi: " + sum;

        }
    }
}
