// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace ScriptingBridgeFinder {
	
	
	// Should subclass MonoMac.AppKit.NSWindow
	[MonoMac.Foundation.Register("MainWindow")]
	public partial class MainWindow {
	}
	
	// Should subclass MonoMac.AppKit.NSWindowController
	[MonoMac.Foundation.Register("MainWindowController")]
	public partial class MainWindowController {
		
		private global::MonoMac.AppKit.NSArrayController __mt_appTableContent;
		
		private global::MonoMac.AppKit.NSTableView __mt_applicationsTable;
		
		private global::MonoMac.AppKit.NSProgressIndicator __mt_progressIndicator;
		
		#pragma warning disable 0169
		[MonoMac.Foundation.Export("launchSelected:")]
		partial void launchSelected (MonoMac.Foundation.NSObject sender);

		[MonoMac.Foundation.Connect("appTableContent")]
		private global::MonoMac.AppKit.NSArrayController appTableContent {
			get {
				this.__mt_appTableContent = ((global::MonoMac.AppKit.NSArrayController)(this.GetNativeField("appTableContent")));
				return this.__mt_appTableContent;
			}
			set {
				this.__mt_appTableContent = value;
				this.SetNativeField("appTableContent", value);
			}
		}
		
		[MonoMac.Foundation.Connect("applicationsTable")]
		private global::MonoMac.AppKit.NSTableView applicationsTable {
			get {
				this.__mt_applicationsTable = ((global::MonoMac.AppKit.NSTableView)(this.GetNativeField("applicationsTable")));
				return this.__mt_applicationsTable;
			}
			set {
				this.__mt_applicationsTable = value;
				this.SetNativeField("applicationsTable", value);
			}
		}
		
		[MonoMac.Foundation.Connect("progressIndicator")]
		private global::MonoMac.AppKit.NSProgressIndicator progressIndicator {
			get {
				this.__mt_progressIndicator = ((global::MonoMac.AppKit.NSProgressIndicator)(this.GetNativeField("progressIndicator")));
				return this.__mt_progressIndicator;
			}
			set {
				this.__mt_progressIndicator = value;
				this.SetNativeField("progressIndicator", value);
			}
		}
	}
}
