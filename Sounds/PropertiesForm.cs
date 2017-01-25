﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sounds
{
    public partial class PropertiesForm : Form
    {
        public PropertiesForm()
        {
            InitializeComponent();
        }

        public PropertiesForm(TagLib.File f) : this()
        {
            fileNameBox.Text = f.Name;
            durationBox.Text = f.Properties.Duration.ToString();
            bitrateBox.Text = f.Properties.AudioBitrate.ToString();
            channelsBox.Text = f.Properties.AudioChannels.ToString();
            sampleRateBox.Text = f.Properties.AudioSampleRate.ToString();

            titleBox.Text = f.Tag.Title;
            albumBox.Text = f.Tag.Album;
            yearBox.Text = f.Tag.Year.ToString();
            trackBox.Text = f.Tag.TrackCount > 0 ?
                string.Format("{0}/{1}", f.Tag.Track, f.Tag.TrackCount)
                : f.Tag.Track.ToString();
            discBox.Text = f.Tag.DiscCount > 0 ?
                string.Format("{0}/{1}", f.Tag.Disc, f.Tag.DiscCount)
                : f.Tag.Disc.ToString();

            artistsBox.Items.AddRange(f.Tag.Performers);
            composersBox.Items.AddRange(f.Tag.Composers);
            genresBox.Items.AddRange(f.Tag.Genres);
            
            albumArtSelector.DisplayMember = "Type";
            albumArtSelector.Items.AddRange(f.Tag.Pictures);
            if (albumArtSelector.Items.Count > 0)
                albumArtSelector.SelectedIndex = 0;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void albumArtSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picture = (TagLib.IPicture)albumArtSelector.SelectedItem;

            albumArtInfo.Text = string.Format("[{0}] {1}",
                picture.MimeType, picture.Description);

            var pictureStream = picture?.Data?.Data;
            if (pictureStream != null)
            {
                using (var ms = new MemoryStream(pictureStream))
                {
                    var b = Image.FromStream(ms);
                    albumArtBox.Image = b;
                }
            }
        }
    }
}