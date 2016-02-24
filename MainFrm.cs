using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace FontVis
{
    public struct LoadedFont
    {
        public Font Font { get; set; }
        public FontFamily FontFamily { get; set; }
    }

    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        string currentFolder;
        LoadedFont currentFont;

        static LoadedFont LoadFont(FileInfo file, int fontSize, FontStyle fontStyle)
        {
            var fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile(file.FullName);
            if (fontCollection.Families.Length < 0)
            {
                throw new InvalidOperationException("No font familiy found when loading font");
            }

            var loadedFont = new LoadedFont();
            loadedFont.FontFamily = fontCollection.Families[0];
            loadedFont.Font = new Font(loadedFont.FontFamily, fontSize, fontStyle, GraphicsUnit.Pixel);
            return loadedFont;
        }

        void loadByFile(string file)
        {
            currentFolder = dlgFolder.SelectedPath = Path.GetDirectoryName(file);
            var fontList = new List<string>();
            fontList.AddRange(Directory.GetFiles(currentFolder, "*.ttf", SearchOption.TopDirectoryOnly));
            fontList.AddRange(Directory.GetFiles(currentFolder, "*.otf", SearchOption.TopDirectoryOnly));
            foreach (var f in fontList)
            {
                fontsList.Items.Add(Path.GetFileName(f));
            }
            fontsList.SelectedItem = Path.GetFileName(file);
            loadCurrentFont();
        }

        void loadFontNames()
        {
            if (dlgFolder.ShowDialog() == DialogResult.OK)
            {
                currentFolder = dlgFolder.SelectedPath;
                var fontList = new List<string>();
                fontList.AddRange(Directory.GetFiles(currentFolder, "*.ttf", SearchOption.TopDirectoryOnly));
                fontList.AddRange(Directory.GetFiles(currentFolder, "*.otf", SearchOption.TopDirectoryOnly));
                foreach (var f in fontList)
                {
                    fontsList.Items.Add(Path.GetFileName(f));
                }
            }
        }

        void loadCurrentFont()
        {
            currentFont = LoadFont(new FileInfo(Path.Combine(currentFolder,
                (string)fontsList.SelectedItem)), (int)numFontSz.Value,
                (ckBold.Checked ? FontStyle.Bold : FontStyle.Regular) |
                (ckItalic.Checked ? FontStyle.Italic : FontStyle.Regular));
            txtTry.Font = currentFont.Font;
        }

        private void MainFrm_Shown(object sender, EventArgs e)
        {
            var args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
                loadByFile(Path.GetFullPath(args[0]));
            else
                loadFontNames();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            loadFontNames();
        }

        private void fontsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCurrentFont();
        }

        private void numFontSz_ValueChanged(object sender, EventArgs e)
        {
            loadCurrentFont();
        }

        private void ckBold_CheckedChanged(object sender, EventArgs e)
        {
            loadCurrentFont();
        }

        private void ckItalic_CheckedChanged(object sender, EventArgs e)
        {
            loadCurrentFont();
        }

        private void contSample_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void contSample_DragDrop(object sender, DragEventArgs e)
        {
            loadByFile(Path.GetFullPath(((string[])e.Data.GetData(DataFormats.FileDrop))[0]));
        }
    }
}
