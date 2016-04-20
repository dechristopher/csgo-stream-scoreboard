using CSGSI;
using CSGSI.Nodes;
using SteamKit2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSGOSS
{
    public partial class UI : Form
    {
        static string[] settings;
        static GameStateListener gsl;
        static string sid;
        static SteamID s;

        public UI()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(stopGSListen);

            settings = grabSid();

            if (settings.Length.Equals(0))
            {
                MessageBox.Show("Please paste your SteamID into the steamid.txt file created in the folder this program is in and restart the program.");
                Environment.Exit(0);
            }
            else
            {
                sid = settings[0];

                //Set custom colors
                if (settings.Length > 1)
                {
                    if (settings.Length.Equals(7))
                    {
                        string u, v, w, x, y, z;

                        u = settings[1];
                        v = settings[2];
                        w = settings[3];
                        x = settings[4];
                        y = settings[5];
                        z = settings[6];

                        setColors(u, v, w, x, y, z);
                    }
                    else
                    {
                        MessageBox.Show("In order to use custom colors, you muse serparate two sets of RGB values in the config.txt file like so:\n\n" +
                            "<steamid> <R> <G> <B> <R> <G> <B>\n\n" +
                            "All values must be within 0-255 and must be separated by spaces. The first set of values are for background color and the second set are for stat counter color. En example configuration would look like the following:\n\n" +
                            "STEAM_0:0:1234 64 64 64 0 192 0");
                    }
                }

                s = new SteamID(sid.Trim());

                if (s.IsValid)
                {
                    gsl = new GameStateListener(3000);
                    gsl.NewGameState += new NewGameStateHandler(OnNewGameState);
                    if (!gsl.Start())
                    {
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Listening...");
                }
                else
                {
                    MessageBox.Show("INVALID STEAMID PROVIDED\n\nSteamID must be in regular SteamID format. EX: STEAM_0:0:39990");
                    Environment.Exit(0);
                }
            }
        }



        private void stopGSListen(object sender, FormClosedEventArgs e)
        {
            if (gsl != null) { gsl.Stop(); }
            Environment.Exit(0);
        }

        void OnNewGameState(GameState gs)
        {
            if (gs.Player.SteamID.Equals(s.ConvertToUInt64().ToString()))
            {
                if (!gs.Player.MatchStats.Kills.ToString().Equals("-1")) { this.kNum.Text = gs.Player.MatchStats.Kills.ToString(); }
                if (!gs.Player.MatchStats.Deaths.ToString().Equals("-1")) { this.dNum.Text = gs.Player.MatchStats.Deaths.ToString(); }
                if (!gs.Player.MatchStats.Assists.ToString().Equals("-1")) { this.aNum.Text = gs.Player.MatchStats.Assists.ToString(); }
                if (!gs.Player.State.RoundKills.ToString().Equals("-1")) { this.kThisRound.Text = gs.Player.State.RoundKills.ToString() + " /"; }

                if (gs.Round.Phase.Equals("freezetime"))
                {
                    this.kThisRound.Text = "0 /";
                }
            }
        }

        string[] grabSid()
        {
            if (File.Exists(@"settings.txt"))
            {
                return System.IO.File.ReadAllText(@"settings.txt").Split(' ');
            }
            else
            {
                string def = "<SteamID> 64 64 64 0 192 0";
                File.WriteAllText(@"settings.txt", def);
                MessageBox.Show("A default settings file called \"settings.txt\" has been created. Please open it and replace <SteamID> with your SteamID 32 which can be found at http://steamid.co");
                Environment.Exit(0);
                return def.Split(' ');
            }
        }

        private void setColors(string u, string v, string w, string x, string y, string z)
        {
            //Background color RGB values
            int br = int.Parse(u);
            int bg = int.Parse(v);
            int bb = int.Parse(w);

            //Number color RGB values
            int r = int.Parse(x);
            int g = int.Parse(y);
            int b = int.Parse(z);

            this.BackColor = Color.FromArgb(br, bg, bb);

            kThisRound.ForeColor = Color.FromArgb(r, g, b);
            kNum.ForeColor = Color.FromArgb(r, g, b);
            dNum.ForeColor = Color.FromArgb(r, g, b);
            aNum.ForeColor = Color.FromArgb(r, g, b);
        }

        private void UI_RClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("This piece of software is free and open-sourced for all public and private use. It is licensed under the MIT license and all attribution must be given back to myself. I will not be held liable or responsible for any damages or issues caused by this software.\n\n" +
                    "Originally created and maintained by:\n\nAndrew DeChristopher >> github.com/dechristopher\nandrewdechristopher@gmail.com", "About Stream Scoreboard");
            }
        }
    }
}
