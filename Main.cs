﻿using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace JungleDiamond
{

    public partial class Main : Form
    {
        // Declaring global variables
        public XDocument xdoc = new XDocument(new XDeclaration("1.0", "utf-8",null ),new XElement("VIOSO"));
        private bool bAddedCom = false; // bool to check if common xml parameters have been already added

        /// <summary>
        /// Stores all folders of interest for VIOSO6 directory
         /// </summary>
        struct ViosoFolders
        {
            //root looks for the user specific Documents folder where VIOSO6 is 
            public static readonly String Root = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "VIOSO", "VIOSO6");

            public const String Scripting = "\\Scripting";
            public const String Calibration = "\\Calibration";
            public const String Export = "\\Export";
        }

        /// <summary>
        /// Stores all filters of interest for Vioso files
        /// </summary>
        struct ViosoFilters
        {
            public const String AllFiles = "All Files (*.*)|*.*";
            public const String Calibration = "Calibration (*.sps)|*.sps";
            public const String Script = "VIOSO Script (*.ini)|*.ini";
            public const String Mask = "VIOSO Mask (*.bmp)|*.bmp";
            public const String VC = "VIOSO VC (*.vcc)|*.vvc";
        }

        /// <summary>
        /// Stores all supported Vioso functions
        /// </summary>
        struct ViosoFunctions
        {
            public const String Load = "Load";
            public const String Save = "Save";
            public const String CopyTransfer = "Copy/Transfer";
            public const String Wait = "Wait";
            public const String Recalibrate = "Recalibrate";
            public const String Recalculate3DBlending = "Recalculate Blending[3D]";
            public const String AddVC = "Add VC to display Geometry";
            public const String LoadVC = "Load VC file";
            public const String CustomContentSpace = "Custom content space conversion";
            public const String ObserverCorrection = "Observer Correction";
            public const String SetMask = "Set Display Mask";
            public const String ColorAdjustment = "Color Adjustment";
            public const String BlendingAdjustment = "Blending Adjustment";
            public const String Export = "Export";
            public const String Shutdown = "Shutdown";
        }

        public Main()
        {
            InitializeComponent();
        }
/// <summary>
/// Initializing the application
/// </summary>
        public void Main_Load(object sender, EventArgs e)
        {
            //Init of title version text
            versionLabel.Text = "v"+Application.ProductVersion;
            // Init of XML file  
            xdoc.Root.Add(new XComment("Generated automatically by VIOSO Script Generator"));
            xdoc.Root.Add(new XElement("File", new XAttribute("version","1.0.0"), new XAttribute("build", "1234")));

            functionBox.Items.Clear();
            functionBox.Items.Add(ViosoFunctions.Load);
            functionBox.Items.Add(ViosoFunctions.Save);
            functionBox.Items.Add(ViosoFunctions.CopyTransfer);
            functionBox.Items.Add(ViosoFunctions.Wait);
            functionBox.Items.Add(ViosoFunctions.Recalibrate);
            functionBox.Items.Add(ViosoFunctions.Recalculate3DBlending);
            functionBox.Items.Add(ViosoFunctions.AddVC);
            functionBox.Items.Add(ViosoFunctions.LoadVC);
            functionBox.Items.Add(ViosoFunctions.CustomContentSpace);
            functionBox.Items.Add(ViosoFunctions.ObserverCorrection);
            functionBox.Items.Add(ViosoFunctions.SetMask);
            functionBox.Items.Add(ViosoFunctions.ColorAdjustment);
            functionBox.Items.Add(ViosoFunctions.BlendingAdjustment);
            functionBox.Items.Add(ViosoFunctions.Export);
            functionBox.Items.Add(ViosoFunctions.Shutdown);


        }



/// <summary>
/// Handles the choice of the functions in the dropdown: puts the corresponding Box in the active panel and shows it.
/// </summary>
        private void functionBox_indexChanged(object sender, EventArgs e)
        {
            // check if we changed to a valid index
            if (functionBox.SelectedIndex != -1)
            {
                addButton.Enabled = true;

                //show the corresponding controls
                switch (functionBox.SelectedItem.ToString())
                {
                    case ViosoFunctions.Load:
                        enableFunctionBox(LoadBox);
                        break;
                    case ViosoFunctions.CopyTransfer:
                        enableFunctionBox(CopyBox);
                        break;
                    case ViosoFunctions.Wait:
                        enableFunctionBox(WaitBox);
                        break;
                    case ViosoFunctions.Save:
                        enableFunctionBox(saveBox);
                        break;
                    case ViosoFunctions.Recalibrate:
                        enableFunctionBox(RecalibBox);

                        InteractBox.SelectedIndex = 0;

                        break;
                    case ViosoFunctions.Recalculate3DBlending:
                        enableFunctionBox(RecalBlendBox);

                        projectionArrangementBox.SelectedIndex = 0;

                        break;
                    case ViosoFunctions.AddVC:
                        enableFunctionBox(AddVcBox);
                        break;
                    case ViosoFunctions.LoadVC:
                        enableFunctionBox(LoadVcBox);
                        break;
                    case ViosoFunctions.CustomContentSpace:
                        enableFunctionBox(CCSBox);
                        break;
                    case ViosoFunctions.Export:
                        enableFunctionBox(ExportBox);

                        expFormatBox.SelectedIndex = 0;
                        expPath.Text = ViosoFolders.Root + ViosoFolders.Export;

                        break;
                    case ViosoFunctions.ObserverCorrection:
                        enableFunctionBox(ObserverCorrectionBox);
                        break;
                    case ViosoFunctions.SetMask:
                        enableFunctionBox(MaskBox);
                        break;
                    case ViosoFunctions.ColorAdjustment:
                        enableFunctionBox(ColorAdjustmentBox);
                        break;
                    case ViosoFunctions.BlendingAdjustment:
                        enableFunctionBox(BlendingAdjustmentBox);
                        break;
                    case ViosoFunctions.Shutdown:
                        activePanel.Controls.Clear();
                        break;
                    default:
                        activePanel.Controls.Clear();
                        Console.WriteLine("No Valid Selection");
                        break;
                }
            }
        }

        /// <summary>
        ///  Puts the Box in the active panel and shows it
        /// </summary>
        /// <param name="functionBox">The Function Box</param>
        private void enableFunctionBox(Control functionBox)
        {
            activePanel.Controls.Clear();
            activePanel.Controls.Add(functionBox);
            functionBox.Visible = true;
            functionBox.Location = new Point(0, 0);
        }
 
        
/// <summary>
/// Adds the user entries to the ScriptList
/// </summary>

        private void addButton_click(object sender, EventArgs e)
        {
            //create a list item
            ListViewItem lvi = new ListViewItem();
            //fill the item depending on the function selected
            if (functionBox.SelectedIndex != -1)
                switch (functionBox.SelectedItem.ToString())
            {
                case ViosoFunctions.Load:
                        //Nb
                        lvi.Text = scriptList.Items.Count.ToString();
                        //Name
                        lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                        //argument
                            //check .sps in file(s) name(s)
                        if (!loadText.Text.EndsWith(".sps")) loadText.Text += ".sps";
                        lvi.SubItems.Add(loadText.Text);
                        //--> add the ScriptList
                        scriptList.Items.Add(lvi);
                        //XML elements
                        xdoc.Root.Add(new XComment("Loading Block"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "load"), new XAttribute("name", "Calib"), new XAttribute("type", "file"), new XAttribute("subtype", "sps"), new XAttribute("use", lvi.Text + ".Load")));
                        xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".Load"), new XAttribute("type", "common"),
                            new XElement("param", new XAttribute("file", loadText.Text))));
                    break;

                case ViosoFunctions.CopyTransfer:
                        //Nb
                        lvi.Text = scriptList.Items.Count.ToString();
                        //Name
                        lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                        //argument
                            //check .sps in file(s) name(s)
                        if (!srcText.Text.EndsWith(".sps")) srcText.Text += ".sps";
                        if (!destText.Text.EndsWith(".sps")) destText.Text += ".sps";
                        lvi.SubItems.Add(srcText.Text + " --> "+ destText.Text);
                        //--> add the ScriptList
                        scriptList.Items.Add(lvi);
                        //XML elements
                        xdoc.Root.Add(new XComment("Transfer Block"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "transfer"), new XAttribute("type", "file"), new XAttribute("use", lvi.Text + ".Transfer")));
                        xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".Transfer"), new XAttribute("type", "transfer"),
                                new XElement("from", new XAttribute("file", srcText.Text)),
                                new XElement("to", new XAttribute("file", destText.Text))));
                    break;

                case ViosoFunctions.Wait:
                        //Nb
                        lvi.Text = scriptList.Items.Count.ToString();
                        //Name
                        lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                        //argument
                        lvi.SubItems.Add(waitDuration.Text + " ms");
                        //--> add the ScriptList
                        scriptList.Items.Add(lvi);
                        // XML elements
                        xdoc.Root.Add(new XComment("Waiting Block"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "Execute"), new XAttribute("type", "Timer"), new XAttribute("subtype", "Sleep"), new XAttribute("use", lvi.Text + ".Sleep")));
                        xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".Sleep"), new XAttribute("type", "common"),
                                new XElement("param", new XAttribute("duration", waitDuration.Text))));
                        break;

                case ViosoFunctions.Save:
                        //Nb
                        lvi.Text = scriptList.Items.Count.ToString();
                        //Name
                        lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                        //argument
                            //check .sps in file(s) name(s)
                        if (!saveText.Text.EndsWith(".sps")) saveText.Text += ".sps";
                        lvi.SubItems.Add(saveText.Text);
                        //--> add the ScriptList
                        scriptList.Items.Add(lvi);
                        //clear panel
                        activePanel.Controls.Clear();
                        //XML elements
                        xdoc.Root.Add(new XComment("Saving Block"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "save"), new XAttribute("type", "file"), new XAttribute("subtype", "sps"), new XAttribute("use", lvi.Text + ".Save")));
                        xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".Save"), new XAttribute("type", "common"),
                            new XElement("param", new XAttribute("file", saveText.Text))));
                    break;
                case ViosoFunctions.Recalibrate:

                        String recalCompound = compoundRecalText.Text;
                        String recalInteractionLevel = String.Empty;

                        switch(InteractBox.SelectedItem.ToString())
                        {
                            case "None": recalInteractionLevel = "minimal"; break;
                            case "Reduced": recalInteractionLevel = "reduced"; break;
                            case "Minimal": recalInteractionLevel = "less"; break;
                            case "All": recalInteractionLevel = "many"; break;
                        }

                        //Nb
                        lvi.Text = scriptList.Items.Count.ToString();
                        //Name
                        lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                        //argument
                        lvi.SubItems.Add(recalCompound + ", [Interaction: " + recalInteractionLevel + "]");
                        //--> add the ScriptList
                        scriptList.Items.Add(lvi);
                        //XML elements
                            //tasks
                        xdoc.Root.Add(new XComment("Recalibration Block"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "create"), new XAttribute("name", "Recalib"), new XAttribute("type", "behaviour"), new XAttribute("subtype", "SingleClientCalib"), new XAttribute("use", lvi.Text + ".Recalibration")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "Recalib"), new XAttribute("state", "finished")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "execute"), new XAttribute("type", "timer"), new XAttribute("subtype", "sleep"), new XAttribute("use", "stdWait")));
                            //define
                        xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".Recalibration"), new XAttribute("type", "BehaviourCreate"),
                                    new XElement("param", new XAttribute("interactLevel", recalInteractionLevel)),
                                    new XElement("display", new XAttribute("tDevice","dc"), new XAttribute("name", recalCompound))));

                        break;
                case ViosoFunctions.Recalculate3DBlending:

                        String blendCompoundName = compoundBlendText.Text;
                        String blendNewCompoundName = newCompoundBlendText.Text.Trim();
                        String blendProjArrangement = String.Empty;

                        if (blendNewCompoundName.Length == 0) blendNewCompoundName = blendCompoundName + "_Reblended";

                        switch (projectionArrangementBox.SelectedItem.ToString())
                        {
                            case "Auto": blendProjArrangement = "strip"; break;
                            case "Horizontal": blendProjArrangement = "hStrip"; break;
                            case "Vertical": blendProjArrangement = "vStrip"; break;
                            case "Grid": blendProjArrangement = "grid"; break;
                        }

                        //Nb
                        lvi.Text = scriptList.Items.Count.ToString();
                        //Name
                        lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                        //argument
                        lvi.SubItems.Add(blendCompoundName + ", new name: " + blendNewCompoundName + ", projectionArrangement : " + blendProjArrangement);
                        //--> add the ScriptList
                        scriptList.Items.Add(lvi);

                        //XML elements
                        //tasks
                        xdoc.Root.Add(new XComment("Blending Recalculate [3D] Block"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "create"), new XAttribute("name", "BlendCalc"), new XAttribute("type", "behaviour"), new XAttribute("subtype", "SingleClientCalib"), new XAttribute("use", lvi.Text + ".BlendCalc.Start")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "BlendCalc"), new XAttribute("state", "Interact.DeviceSel")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "configure"), new XAttribute("name", "BlendCalc"), new XAttribute("state", "DeviceSel"), new XAttribute("use", lvi.Text + ".BlendCalc.Config")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "execute"), new XAttribute("name", "BlendCalc"), new XAttribute("type", "progress"), new XAttribute("subtype", "next")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "BlendCalc"), new XAttribute("state", "finished")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "execute"), new XAttribute("type", "timer"), new XAttribute("subtype", "sleep"), new XAttribute("use", "stdWait")));
                        
                        //define
                        xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".BlendCalc.Start"), new XAttribute("type", "BehaviourCreate"),
                                    new XElement("param", new XAttribute("interactLevel", "many,noFinalResult")),
                                    new XElement("display", new XAttribute("tDevice","dc"), new XAttribute("name", blendCompoundName))));
                        xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".BlendCalc.Config"), new XAttribute("type", "SC_DevSel"),
                                    new XElement("param", new XAttribute("tCalib", "preceeding"), new XAttribute("tArrangement", blendProjArrangement), new XAttribute("calibName", blendNewCompoundName))));
                    break;
                case ViosoFunctions.AddVC:
                        //Nb
                        lvi.Text = scriptList.Items.Count.ToString();
                        //Name
                        lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                        //argument
                        lvi.SubItems.Add(compoundVCText.Text);
                        //--> add the ScriptList
                        scriptList.Items.Add(lvi);
                        //XML elements
                            //tasks
                        xdoc.Root.Add(new XComment("Conversion Block: Add VC to display geometry"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "create"), new XAttribute("name", "AddVCtoP2C"), new XAttribute("type", "behaviour"), new XAttribute("subtype", "Convert")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "AddVCtoP2C"), new XAttribute("state", "Interact.Convert")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "configure"), new XAttribute("name", "AddVCtoP2C"), new XAttribute("state", "ConvertConfig"), new XAttribute("use", lvi.Text + ".AddVC")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "start"), new XAttribute("name", "AddVCtoP2C")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "AddVCtoP2C"), new XAttribute("state", "finished")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "execute"), new XAttribute("type", "timer"), new XAttribute("subtype", "sleep"), new XAttribute("use", "stdWait")));

                            //define
                        xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".AddVC"), new XAttribute("type", "CalibCommerce"),
                                         new XElement("display", new XAttribute("tDevice", "dc"), new XAttribute("name", compoundVCText.Text)),
                                         new XElement("param", new XAttribute("tConvert", "add vc to P2C"))));
                    break;

                case ViosoFunctions.LoadVC:
                        //Nb
                        lvi.Text = scriptList.Items.Count.ToString();
                        //Name
                        lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                        //argument
                        lvi.SubItems.Add(vcFilePathText.Text);
                        //--> add to the ScriptList
                        scriptList.Items.Add(lvi);
                        //XML elements - all in the task element, no define
                        xdoc.Root.Add(new XComment("Load VC File Block"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "load"),
                            new XAttribute("name", "LoadVCfile"+ lvi.Text),  //incremental name to allow multiple blocks
                            new XAttribute("type", "file"), 
                            new XAttribute("subtype", "vc"),
                                new XElement("param", new XAttribute("file", vcFilePathText.Text)),
                                new XElement("display",new XAttribute("tDevice", "dc"), new XAttribute("name", compoundVCfileText.Text))
                            ));
                        break;

                case ViosoFunctions.CustomContentSpace:
                   
                        //Nb
                        lvi.Text = scriptList.Items.Count.ToString();
                        //Name
                        lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                        //argument
                        lvi.SubItems.Add(compoundCCSText.Text+", Space: "+ccsText.Text);
                        //--> add the ScriptList
                        scriptList.Items.Add(lvi);

                        //XML Elements
                        //Tasks
                        xdoc.Root.Add(new XComment("Conversion Block: Custom content space conversion"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "create"), new XAttribute("name", "ContentSpace"), new XAttribute("type", "behaviour"), new XAttribute("subtype", "Convert")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "ContentSpace"), new XAttribute("state", "Interact.Convert")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "configure"), new XAttribute("name", "ContentSpace"), new XAttribute("state", "ConvertConfig"), new XAttribute("use", lvi.Text + ".CCS_BLOCK")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "start"), new XAttribute("name", "ContentSpace")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "ContentSpace"), new XAttribute("state", "finished")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "execute"), new XAttribute("type", "timer"), new XAttribute("subtype", "sleep"), new XAttribute("use", "stdWait")));

                        //define
                        xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".CCS_BLOCK"), new XAttribute("type", "CalibCommerce"),
                                        new XElement("display", new XAttribute("tDevice", "dc"), new XAttribute("name", compoundCCSText.Text)),
                                        new XElement("param", new XAttribute("tConvert", "custom content space conversion"), new XAttribute("customContentSpace", ccsText.Text))
                                      ));

                    break;
                case ViosoFunctions.Export:
                        String expCompound = compoundExpText.Text;
                        Boolean useExportScript = expIsUseSettingsFile.Checked;
                        String expFormat = expFormatBox.SelectedItem.ToString();
                        String expSplitDisplay = expIsSplitDisplay.Checked ? "1" : "0";
                        String exp3D = expIs3D.Checked ? "1" : "0";
                        String fullPath = expPath.Text + @"\" + expName.Text;

                        //Nb
                        lvi.Text = scriptList.Items.Count.ToString();
                        //Name
                        lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                        //argument
                        if (useExportScript) {
                            lvi.SubItems.Add(expCompound + ", Use Export Script file = " + useExportScript);
                        } else {
                            lvi.SubItems.Add(expCompound + ", Dest.:" + fullPath + ", Format: " + expFormat + ", 3D=" + exp3D + ", SplitDisplay=" + expSplitDisplay);
                        }
                        //--> add the ScriptList
                        scriptList.Items.Add(lvi);
  
                        //XML Elements
                        //Task
                        xdoc.Root.Add(new XComment("Export Block"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "create"), new XAttribute("name", "Export"), new XAttribute("type", "behaviour"), new XAttribute("subtype", "export")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "Export"), new XAttribute("state", "Interact.Export")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "configure"), new XAttribute("name", "Export"), new XAttribute("state", "ExportConfig"), new XAttribute("use", lvi.Text + ".Export")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "start"), new XAttribute("name", "Export")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "Export"), new XAttribute("state", "finished")));

                        //define
                        XElement exportParam = new XElement("param");

                        if (useExportScript) {
                            exportParam.Add(new XAttribute("bExtendedDefFile", "1"));
                        } else {
                            exportParam.Add(new XAttribute("tConvert", expFormatBox.SelectedItem.ToString()),
                                            new XAttribute("path", expPath.Text),
                                            new XAttribute("name", expName.Text),
                                            new XAttribute("bSplitDisplays", expSplitDisplay),
                                            new XAttribute("b3D", exp3D),
                                            new XAttribute("bExactFileName", "1")
                                            );
                        }

                        xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".Export"), new XAttribute("type", "CalibCommerce"),
                                        new XElement("display", new XAttribute("tDevice", "dc"), new XAttribute("name", compoundExpText.Text)),
                                        exportParam
                            ));
                                      
                        break;
                 case ViosoFunctions.ObserverCorrection:
                        String ocDisplay = displayOCText.Text;
                        String ocViewport = viewportOCText.Text;
                        String scaleHorizontal = hScaleOCText.Text;
                        String scaleVertical = vScaleOCText.Text;
                        String offsetHorizontal = hOffsetOCText.Text;
                        String offsetVertical = vOffsetOCText.Text;

                        //Nb
                        lvi.Text = scriptList.Items.Count.ToString();
                        //Name
                        lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                        //argument
                        lvi.SubItems.Add(ocDisplay + ", " + ocViewport + ", Scale(" + scaleHorizontal + ", " + scaleVertical + "), Offset(" + offsetHorizontal + ", " + offsetVertical + ")");
                        //--> add the ScriptList
                        scriptList.Items.Add(lvi);

                        //XML Elements
                        //Task
                        xdoc.Root.Add(new XComment("Conversion Block: Observer Correction"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "create"), new XAttribute("name", "ObserverLeft"), new XAttribute("type", "behaviour"), new XAttribute("subtype", "Convert")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "ObserverLeft"), new XAttribute("state", "Interact.Convert")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "configure"), new XAttribute("name", "ObserverLeft"), new XAttribute("state", "ConvertConfig"), new XAttribute("use", lvi.Text + ".OC")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "start"), new XAttribute("name", "ObserverLeft")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "wait"), new XAttribute("name", "ObserverLeft"), new XAttribute("state", "finished")));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "execute"), new XAttribute("type", "timer"), new XAttribute("subtype", "sleep"), new XAttribute("use", "stdWait")));

                        //define
                        xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".OC"), new XAttribute("type", "CalibCommerce"), 
                                           new XElement("display", new XAttribute("tDevice", "sd"), new XAttribute("name", ocDisplay)),
                                           new XElement("param", new XAttribute("tConvert", "observer conversion"), new XAttribute("customContentSpace", ocViewport), new XAttribute("bNoDefaultParam", "1")),
                                           new XElement("param0", new XAttribute("X", scaleHorizontal), new XAttribute("Y", offsetHorizontal), new XAttribute("Z", scaleVertical), new XAttribute("W", offsetVertical))
                            ));

                        break;

                    case ViosoFunctions.SetMask:
                        //check .bmp in file(s) name(s)
                        if (!maskFileText.Text.EndsWith(".bmp")) maskFileText.Text += ".bmp";


                        String mCompound = compoundMaskText.Text;
                        String mDisplay = displayMaskText.Text;
                        String mMaskFile = maskFileText.Text;


                        //Nb
                        lvi.Text = scriptList.Items.Count.ToString();
                        //Name
                        lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                        //argument
                        lvi.SubItems.Add(mCompound + ", " + mDisplay + ", File: " + mMaskFile);
                        //--> add the ScriptList
                        scriptList.Items.Add(lvi);

                        //XML Element
                        xdoc.Root.Add(new XComment("Set Mask from File"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "manipulate"), new XAttribute("type", "calibration"), new XAttribute("subtype", "Mask"), new XAttribute("use", lvi.Text + ".Mask")));

                        //define
                        xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".Mask"), new XAttribute("type", "CalibChange"),
                                            new XElement("display", new XAttribute("tDevice", "dc"), new XAttribute("name", mCompound)),
                                            new XElement("param", new XAttribute("bAABorder", "0")),
                                            new XElement("change", new XAttribute("tManipulate", "set mask"), new XAttribute("tDevice", "sd"), new XAttribute("name", mDisplay), new XAttribute("maskFile", mMaskFile))
                            ));
                        break;
                    case ViosoFunctions.ColorAdjustment:
                        String caCompound = compoundCAText.Text;
                        String caDisplay = displayCAText.Text;
                        float caRChannel = Decimal.ToSingle(rChannel.Value) / 255;
                        float caGChannel = Decimal.ToSingle(gChannel.Value) / 255;
                        float caBChannel = Decimal.ToSingle(bChannel.Value) / 255;

                        //Nb
                        lvi.Text = scriptList.Items.Count.ToString();
                        //Name
                        lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                        //argument
                        lvi.SubItems.Add(caCompound + ", " + caDisplay + ", R:" + caRChannel + ", G: " + caGChannel + ", B: " + caBChannel);
                        //--> add the ScriptList
                        scriptList.Items.Add(lvi);

                        //XML Element
                        xdoc.Root.Add(new XComment("Calibration Adjustment: Color"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "manipulate"), new XAttribute("type", "calibration"), new XAttribute("subtype", "CalibChange"), new XAttribute("use", lvi.Text + ".CA")));
                        
                        //define
                        xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".CA"), new XAttribute("type", "CalibChange"),
                                            new XElement("display", new XAttribute("tDevice", "dc"), new XAttribute("name", caCompound)),
                                            new XElement("param", new XAttribute("bAABorder", "0")),
                                            new XElement("change", new XAttribute("tManipulate", "power value"), new XAttribute("tDevice", "sd"), new XAttribute("name", caDisplay), new XAttribute("red", caRChannel), new XAttribute("green", caGChannel), new XAttribute("blue", caBChannel))
                            ));

                        break;
                    case ViosoFunctions.BlendingAdjustment:
                        String baCompound = compoundBAText.Text;
                        String baDisplay = displayBAText.Text;
                        String baPlateauChannel = plateauChannel.Value.ToString();
                        String baGradientChannel = gradientChannel.Value.ToString();
                        String baGammaChannel = gammaChannel.Value.ToString();
                        String baProjectionChannel = projectionChannel.Value.ToString();

                        //Nb
                        lvi.Text = scriptList.Items.Count.ToString();
                        //Name
                        lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                        //argument
                        lvi.SubItems.Add(baCompound + ", " + baDisplay + ", Plateau:" + baPlateauChannel + ", Gradient: " + baGradientChannel + ", Gamma: " + baGammaChannel + ", Projection: " + baProjectionChannel);
                        //--> add the ScriptList
                        scriptList.Items.Add(lvi);

                        //XML Element
                        xdoc.Root.Add(new XComment("Calibration Adjustment: Blending"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "manipulate"), new XAttribute("type", "calibration"), new XAttribute("subtype", "blending"), new XAttribute("use", lvi.Text + ".BA")));

                        //define
                        xdoc.Root.Add(new XElement("define", new XAttribute("name", lvi.Text + ".BA"), new XAttribute("type", "BlendParam"),
                                            new XElement("display", new XAttribute("tDevice", "dc"), new XAttribute("name", baCompound)),
                                            new XElement("param", 
                                                new XAttribute("tMethod", "standard"),
                                                new XAttribute("plateau", baPlateauChannel),
                                                new XAttribute("gradient", baGradientChannel),
                                                new XAttribute("gamma", baGammaChannel),
                                                new XAttribute("gammaPrj", baProjectionChannel)
                                            )
                        ));
                        break;
                    
                    case ViosoFunctions.Shutdown:
                        //Nb
                        lvi.Text = scriptList.Items.Count.ToString();
                        //Name
                        lvi.SubItems.Add(functionBox.SelectedItem.ToString());
                        //argument
                        lvi.SubItems.Add("-");
                        //--> add the ScriptList
                        scriptList.Items.Add(lvi);
                        // XML elements
                        xdoc.Root.Add(new XComment("Shutdown VIOSO"));
                        xdoc.Root.Add(new XElement("task", new XAttribute("action", "Execute"), new XAttribute("type", "App"), new XAttribute("subtype", "Shutdown")));
                        break;

                    default:
                    Console.WriteLine("No Valid Selection");
                    break;
            }
            //Butto & UI reset
            addButton.Enabled = false;
            activePanel.Controls.Clear();
            functionBox.SelectedIndex = -1;
 
        }


        /// <summary>
        /// Generates and saves the XML document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateScript_Click(object sender, EventArgs e)
        {
            //generate common XML elements at the end of document: add Wait 3000 (only once)
            if ((xdoc.Root.LastNode != null) && (!bAddedCom))
            {
                bAddedCom = true;
                xdoc.Root.Add(new XComment("Default Waiting Block"));
                xdoc.Root.LastNode.AddAfterSelf(new XElement("define", new XAttribute("name", "stdWait"), new XAttribute("type", "common"),
                                                new XElement("param", new XAttribute("duration", "3000"))));
            }
         
            //SAVE dialog
            String saveFileName = String.Empty;
            if (showSaveFileDialog(ref saveFileName, ViosoFolders.Scripting, ViosoFilters.Script)) 
            {
                //Write XML file with UTF8 and no BOM
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Encoding = new UTF8Encoding(false); // do not emit the BOM.
                settings.Indent = true; 
                using (XmlWriter w = XmlWriter.Create(saveFileName, settings))
                {
                    xdoc.Save(w);
                }

                //write .bat file
                if (MessageBox.Show("Do you also want to generate an executable (.bat) for one-click recalibration?", "Script Successfully Generated ☑", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string filename = ViosoFolders.Root+ ViosoFolders.Scripting+"\\One-Click Recalibration" +".bat";
                    using (StreamWriter writer = File.CreateText(filename))
                    {
                        writer.WriteLine("@echo off");
                        writer.WriteLine("echo VIOSO Recalibration: Do you want to launch the process?");
                        writer.WriteLine("pause");
                        writer.WriteLine("\"C:\\Program Files\\VIOSO6\\SPCalibrator64.exe\"" + " /H:\"" + saveFileName + "\" /M ");
                        writer.WriteLine("echo ");
                        writer.WriteLine("echo VIOSO Recalibration finished!");
                        writer.WriteLine("pause");
                    }
                }

                //prompt folder of the file created
                String dir = Path.GetDirectoryName(saveFileName);
                Process.Start(dir);
            }

        }

       /// <summary>
       /// Shows a SaveFileDialog and writes the selected Filename in 'saveFile'.
       /// Returns true, if a file name is selected.
       /// </summary>
       /// <param name="saveFile">File name</param>
       /// <returns>true, if a file name is selected</returns>
        private bool showSaveFileDialog(ref String saveFile, String viosoFolder, String viosoFilter)
        {
            saveFileDialog1.FileName = String.Empty;
            saveFileDialog1.Filter = viosoFilter;
            saveFileDialog1.InitialDirectory = ViosoFolders.Root + viosoFolder;
            DialogResult dialogResult = saveFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                saveFile = saveFileDialog1.FileName;
            }

            return saveFile.Length > 0;
        }


        /// <summary>
        /// Shows a OpenFileDialog and writes the selected Filename in 'selectedFile'.
        /// Returns true, if a file is selected.
        /// </summary>
        /// <param name="selectedFile">File name</param>
        /// <returns>true, if a file is selected</returns>
        private bool showSelectFileDialog(ref String selectedFile, String viosoFilter, String viosoFolder = "")
        {
            openFileDialog1.Filter = viosoFilter + "|" + ViosoFilters.AllFiles;
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = ViosoFolders.Root + viosoFolder;
            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                String fileName = openFileDialog1.FileName;
                String ViosoPath = ViosoFolders.Root + viosoFolder;
                //checks if the path is the VIOSO root to leave only the file name
                if (fileName.Contains(ViosoFolders.Root + viosoFolder))
                    selectedFile = fileName.Substring(ViosoPath.Length+1);
                else selectedFile = fileName;
            }

            return selectedFile.Length > 0;
        }

        /// <summary>
        /// Reset the GUI and XML
        /// </summary>
        private void resetButton_Click(object sender, EventArgs e)
        {
            xdoc.Root.RemoveAll();
            bAddedCom = false;
            scriptList.Items.Clear();
            addButton.Enabled = false;
            activePanel.Controls.Clear();
            functionBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Handle the click event for the SelectExportDestination Button.
        /// </summary>

        private void btnSelectExportDestination_Click(object sender, EventArgs e)
        {
            String selectedPath = String.Empty;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedPath = folderBrowserDialog1.SelectedPath;
                expPath.Text = selectedPath;
            }

        }

        /// <summary>
        /// Handle the click event for the Load Button.
        /// </summary>

        private void btnLoad_Click(object sender, EventArgs e)
        {
            String selectedFile = String.Empty;
            if (showSelectFileDialog(ref selectedFile, ViosoFilters.Calibration, ViosoFolders.Calibration))
            {
                loadText.Text = selectedFile;
            }
        }

        /// <summary>
        /// Handle the click event for the BrowseSourceTransfer Button.
        /// </summary>

        private void btnBrowseSourceTransfer_Click(object sender, EventArgs e)
        {
            String selectedFile = String.Empty;
            if (showSelectFileDialog(ref selectedFile, ViosoFilters.Calibration, ViosoFolders.Calibration))
            {
                srcText.Text = selectedFile;
            }
        }

        /// <summary>
        /// Handle the click event for the BrowseDestinationTransfer Button.
        /// </summary>

        private void btnBrowseDestinationTransfer_Click(object sender, EventArgs e)
        {
            String destinationFile = String.Empty;
            if (showSaveFileDialog(ref destinationFile, ViosoFolders.Calibration, ViosoFilters.Calibration))
            {
                String ViosoPath = ViosoFolders.Root + ViosoFolders.Calibration ;
                //check if we are in default VIOSO path
                if (destinationFile.Contains(ViosoPath))
                    destinationFile = destinationFile.Substring(ViosoPath.Length + 1);
                destText.Text = destinationFile;
            }
        }

        /// <summary>
        /// Handle the click event for the BrowseSave Button.
        /// </summary>
        private void btnBrowseSave_Click(object sender, EventArgs e)
        {
            String saveFile = String.Empty;
            if (showSaveFileDialog(ref saveFile, ViosoFolders.Calibration, ViosoFilters.Calibration))
            {
                saveText.Text = saveFile;
            }
        }

        /// <summary>
        /// Handle the click event for the SelectMask Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetMask_Click(object sender, EventArgs e)
        {
            String selectedMaskFile = String.Empty;
            if (showSelectFileDialog(ref selectedMaskFile, ViosoFilters.Mask)) {
                maskFileText.Text = selectedMaskFile;
            }
        }

        /// <summary>
        /// Toggle the input fields on or off, wether the "Use Script file" option is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chckBox_exportIsFile_CheckedChanged(object sender, EventArgs e)
        {
            Boolean isEnabled = !expIsUseSettingsFile.Checked;

            expFormatBox.Enabled = isEnabled;
            expIs3D.Enabled = isEnabled;
            expIsSplitDisplay.Enabled = isEnabled;
            expName.Enabled = isEnabled;
            expPath.Enabled = isEnabled;
            btnSelectExportDestination.Enabled = isEnabled;
        }

        private void btnBrowseVCfile_Click(object sender, EventArgs e)
        {
            String selectedVCFile = String.Empty;
            if (showSelectFileDialog(ref selectedVCFile, ViosoFilters.VC,ViosoFolders.Calibration))
            {
                vcFilePathText.Text = selectedVCFile;
            }
        }
    }
}
