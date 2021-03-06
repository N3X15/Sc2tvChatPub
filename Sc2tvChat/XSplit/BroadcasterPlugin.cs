﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="XsplitPlugin.cs" company="Starboard">
//   Copyright © 2011 All Rights Reserved
// </copyright>
// <author> William Eddins </author>
// <summary>
//   Encapsulates logic behind sending plugin updates to the XSplit rendering system. Instances should be
//   created through the CreateInstance static method, which ensures XSplit is installed when attempting
//   to create the COM object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace XSplit.Wpf
{
    //using System;
    //using System.IO;
    //using System.Runtime.InteropServices;
    //using System.Threading.Tasks;
    //using System.Windows;
    //using System.Windows.Media;
    //using System.Windows.Media.Imaging;

    //using VHMediaCOMLib;

    //public class XsplitPlugin {
    //    #region Constants and Fields

    //    /// <summary>
    //    ///   Instance of the XSplit COM object.
    //    /// </summary>
    //    private readonly VHCOMRenderEngineExtSrc2 xsplit;

    //    #endregion

    //    #region Constructors and Destructors

    //    /// <summary>
    //    /// Initializes a new instance of the <see cref="XsplitPlugin"/> class. 
    //    ///   Prevents the class from being manually created.
    //    /// </summary>
    //    /// <param name="xsplit">
    //    /// The xsplit instance to attach.
    //    /// </param>
    //    protected XsplitPlugin( VHCOMRenderEngineExtSrc2 xsplit ) {
    //        this.xsplit = xsplit;
    //    }

    //    #endregion

    //    #region Public Properties

    //    /// <summary>
    //    ///   Gets a value indicating whether the XSplit connection is ready to receive images.
    //    /// </summary>
    //    public bool ConnectionIsReady {
    //        get {
    //            return (this.xsplit.ConnectionStatus & 3) == 3;
    //        }
    //    }

    //    #endregion

    //    #region Public Methods

    //    /// <summary>
    //    /// Attempts to create an instance of the XsplitPlugin class. If XSplit is not installed, null is returned.
    //    /// </summary>
    //    /// <param name="connectionUID">
    //    /// Unique ID to apply to this application, should match the accompanying .xbs file.
    //    /// </param>
    //    /// <returns>
    //    /// Returns an instance of XsplitPlugin if XSplit is installed on the system, else null is returned.
    //    /// </returns>
    //    public static XsplitPlugin CreateInstance( string connectionUID ) {
    //        XsplitPlugin plugin = null;

    //        try {
    //            var extsrc = new VHCOMRenderEngineExtSrc2 { ConnectionUID = connectionUID };
    //            plugin = new XsplitPlugin(extsrc);
    //        } catch (COMException) {
    //            // Do nothing, the plugin failed to load so null will be returned.
    //        }

    //        return plugin;
    //    }

     
    //    public bool RenderVisual( Visual obj, int width, int height ) {
    //        if (obj == null)
    //            return false;

    //        if (this.ConnectionIsReady) {
    //            var bmp = new RenderTargetBitmap(
    //                width, height, 96, 96,
    //                PixelFormats.Default);

    //            var elementBrush = new VisualBrush(obj);
    //            var visual = new DrawingVisual();
    //            var dc = visual.RenderOpen();
    //            dc.DrawRectangle(elementBrush, null, new Rect(0, 0, width, height));
    //            dc.Close();

    //            bmp.Render(visual);

    //            // The remaining work (format conversion, sending to xsplit) can be done on a seperate thread)
    //            Task.Factory.StartNew(
    //                () => {
    //                    var encoder = new BmpBitmapEncoder();
    //                    encoder.Frames.Add(BitmapFrame.Create(bmp));

    //                    using (var stream = new MemoryStream()) {
    //                        encoder.Save(stream);

    //                        //stream.Position = 0;

    //                        byte[] bytes = stream.ToArray();
    //                        int length = width * height * 4;

    //                        IntPtr dataptr = Marshal.AllocCoTaskMem(length);
    //                        Marshal.Copy(bytes, bytes.Length - length, dataptr, length);
    //                        this.xsplit.SendFrame((uint)width, (uint)height, dataptr.ToInt32());
    //                        Marshal.FreeCoTaskMem(dataptr);
    //                    }
    //                });
    //            return true;
    //        }

    //        return false;
    //    }

    //    #endregion
    //}
}