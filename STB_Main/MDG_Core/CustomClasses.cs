using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MDG_Core
{
    /// <summary>
    /// Color pallete group.
    /// </summary>
    public class ColorPallete
    {
        /// <summary>
        /// Name of the color pallete.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Background color.
        /// </summary>
        public Color Background { get; set; }
        /// <summary>
        /// Foreground color.
        /// </summary>
        public Color Foreground { get; set; }
        /// <summary>
        /// Highlight color.
        /// </summary>
        public Color Highlight { get; set; }
        /// <summary>
        /// Text color.
        /// </summary>
        public Color Text { get; set; }
    }

    /// <summary>
    /// User control module.
    /// </summary>
    public class UCModule
    {
        /// <summary>
        /// Name to display.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Code name associated.
        /// </summary>
        public string UCControl { get; set; }
    }

    /// <summary>
    /// File template.
    /// </summary>
    public class FileTemplate
    {
        /// <summary>
        /// Display name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Source file to copy from.
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// Determines if the file is created in a read-only state.
        /// </summary>
        public bool ReadOnly { get; set; }
        /// <summary>
        /// Determines if the file is created in a hidden state.
        /// </summary>
        public bool Hidden { get; set; }
    }

    /// <summary>
    /// Folder template.
    /// </summary>
    public class FolderTemplate
    {
        /// <summary>
        /// Display name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Determines if the folder is created in a hidden state.
        /// </summary>
        public bool Hidden { get; set; }
        /// <summary>
        /// List of the folder contents.
        /// </summary>
        public List<object> Contents { get; set; }
    }

    /// <summary>
    /// Metadata class for new job template.
    /// </summary>
    public class MetaData
    {
        /// <summary>
        /// Name of the template.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Last edit date (come at me).
        /// </summary>
        public DateTime CreationDate { get; set; }
    }

    /// <summary>
    /// New job template class.
    /// </summary>
    public class JobTemplate
    {
        /// <summary>
        /// The master directory.
        /// </summary>
        public FolderTemplate MasterDirectory { get; set; }
        /// <summary>
        /// The metadata.
        /// </summary>
        public MetaData MetaData { get; set; }
    }
}
