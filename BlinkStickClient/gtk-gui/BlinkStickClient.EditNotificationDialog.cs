
// This file has been generated by the GUI designer. Do not modify.
namespace BlinkStickClient
{
	public partial class EditNotificationDialog
	{
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.Frame frame1;
		
		private global::Gtk.Alignment GtkAlignment2;
		
		private global::Gtk.Table table2;
		
		private global::Gtk.Button buttonEditPatterns;
		
		private global::Gtk.CheckButton checkbuttonEnabled;
		
		private global::Gtk.ComboBox comboboxPattern;
		
		private global::Gtk.Entry entryName;
		
		private global::Gtk.HBox hboxChannel;
		
		private global::Gtk.ComboBox comboboxChannel;
		
		private global::Gtk.HBox hboxLedConfiguration;
		
		private global::Gtk.SpinButton spinbuttonLedsFrom;
		
		private global::Gtk.Label labelLedsTo;
		
		private global::Gtk.SpinButton spinbuttonLedsTo;
		
		private global::Gtk.Label labelBlinkStick;
		
		private global::Gtk.Label labelChannel;
		
		private global::Gtk.Label labelLeds;
		
		private global::Gtk.Label labelName;
		
		private global::Gtk.Label labelPattern;
		
		private global::Gtk.Label GtkLabel2;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BlinkStickClient.EditNotificationDialog
			this.Name = "BlinkStickClient.EditNotificationDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Edit Notification");
			this.Resizable = false;
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Internal child BlinkStickClient.EditNotificationDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.table2 = new global::Gtk.Table (((uint)(6)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.buttonEditPatterns = new global::Gtk.Button ();
			this.buttonEditPatterns.CanFocus = true;
			this.buttonEditPatterns.Name = "buttonEditPatterns";
			this.buttonEditPatterns.UseUnderline = true;
			global::Gtk.Image w2 = new global::Gtk.Image ();
			w2.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("BlinkStickClient.Resources.icons.icon-dark-pencil-square-o.png");
			this.buttonEditPatterns.Image = w2;
			this.table2.Add (this.buttonEditPatterns);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2 [this.buttonEditPatterns]));
			w3.TopAttach = ((uint)(5));
			w3.BottomAttach = ((uint)(6));
			w3.LeftAttach = ((uint)(2));
			w3.RightAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.checkbuttonEnabled = new global::Gtk.CheckButton ();
			this.checkbuttonEnabled.CanFocus = true;
			this.checkbuttonEnabled.Name = "checkbuttonEnabled";
			this.checkbuttonEnabled.Label = global::Mono.Unix.Catalog.GetString ("Enabled");
			this.checkbuttonEnabled.DrawIndicator = true;
			this.checkbuttonEnabled.UseUnderline = true;
			this.table2.Add (this.checkbuttonEnabled);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.checkbuttonEnabled]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.comboboxPattern = new global::Gtk.ComboBox ();
			this.comboboxPattern.Name = "comboboxPattern";
			this.table2.Add (this.comboboxPattern);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2 [this.comboboxPattern]));
			w5.TopAttach = ((uint)(5));
			w5.BottomAttach = ((uint)(6));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryName = new global::Gtk.Entry ();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.table2.Add (this.entryName);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryName]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hboxChannel = new global::Gtk.HBox ();
			this.hboxChannel.Name = "hboxChannel";
			this.hboxChannel.Spacing = 6;
			// Container child hboxChannel.Gtk.Box+BoxChild
			this.comboboxChannel = global::Gtk.ComboBox.NewText ();
			this.comboboxChannel.AppendText (global::Mono.Unix.Catalog.GetString ("R"));
			this.comboboxChannel.AppendText (global::Mono.Unix.Catalog.GetString ("G"));
			this.comboboxChannel.AppendText (global::Mono.Unix.Catalog.GetString ("B"));
			this.comboboxChannel.Name = "comboboxChannel";
			this.hboxChannel.Add (this.comboboxChannel);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hboxChannel [this.comboboxChannel]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			this.table2.Add (this.hboxChannel);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table2 [this.hboxChannel]));
			w8.TopAttach = ((uint)(4));
			w8.BottomAttach = ((uint)(5));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hboxLedConfiguration = new global::Gtk.HBox ();
			this.hboxLedConfiguration.Name = "hboxLedConfiguration";
			this.hboxLedConfiguration.Spacing = 6;
			// Container child hboxLedConfiguration.Gtk.Box+BoxChild
			this.spinbuttonLedsFrom = new global::Gtk.SpinButton (0, 63, 1);
			this.spinbuttonLedsFrom.CanFocus = true;
			this.spinbuttonLedsFrom.Name = "spinbuttonLedsFrom";
			this.spinbuttonLedsFrom.Adjustment.PageIncrement = 10;
			this.spinbuttonLedsFrom.ClimbRate = 1;
			this.spinbuttonLedsFrom.Numeric = true;
			this.hboxLedConfiguration.Add (this.spinbuttonLedsFrom);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hboxLedConfiguration [this.spinbuttonLedsFrom]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hboxLedConfiguration.Gtk.Box+BoxChild
			this.labelLedsTo = new global::Gtk.Label ();
			this.labelLedsTo.Name = "labelLedsTo";
			this.labelLedsTo.LabelProp = global::Mono.Unix.Catalog.GetString ("to");
			this.hboxLedConfiguration.Add (this.labelLedsTo);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hboxLedConfiguration [this.labelLedsTo]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hboxLedConfiguration.Gtk.Box+BoxChild
			this.spinbuttonLedsTo = new global::Gtk.SpinButton (0, 63, 1);
			this.spinbuttonLedsTo.CanFocus = true;
			this.spinbuttonLedsTo.Name = "spinbuttonLedsTo";
			this.spinbuttonLedsTo.Adjustment.PageIncrement = 10;
			this.spinbuttonLedsTo.ClimbRate = 1;
			this.spinbuttonLedsTo.Numeric = true;
			this.hboxLedConfiguration.Add (this.spinbuttonLedsTo);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hboxLedConfiguration [this.spinbuttonLedsTo]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			this.table2.Add (this.hboxLedConfiguration);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2 [this.hboxLedConfiguration]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelBlinkStick = new global::Gtk.Label ();
			this.labelBlinkStick.Name = "labelBlinkStick";
			this.labelBlinkStick.Xalign = 1F;
			this.labelBlinkStick.LabelProp = global::Mono.Unix.Catalog.GetString ("BlinkStick:");
			this.table2.Add (this.labelBlinkStick);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelBlinkStick]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelChannel = new global::Gtk.Label ();
			this.labelChannel.Name = "labelChannel";
			this.labelChannel.Xalign = 1F;
			this.labelChannel.LabelProp = global::Mono.Unix.Catalog.GetString ("Channel:");
			this.table2.Add (this.labelChannel);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelChannel]));
			w14.TopAttach = ((uint)(4));
			w14.BottomAttach = ((uint)(5));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelLeds = new global::Gtk.Label ();
			this.labelLeds.Name = "labelLeds";
			this.labelLeds.Xalign = 1F;
			this.labelLeds.LabelProp = global::Mono.Unix.Catalog.GetString ("LEDs:");
			this.table2.Add (this.labelLeds);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelLeds]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelName = new global::Gtk.Label ();
			this.labelName.Name = "labelName";
			this.labelName.Xalign = 1F;
			this.labelName.LabelProp = global::Mono.Unix.Catalog.GetString ("Name:");
			this.table2.Add (this.labelName);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelName]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelPattern = new global::Gtk.Label ();
			this.labelPattern.Name = "labelPattern";
			this.labelPattern.Xalign = 1F;
			this.labelPattern.LabelProp = global::Mono.Unix.Catalog.GetString ("Pattern:");
			this.table2.Add (this.labelPattern);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table2 [this.labelPattern]));
			w17.TopAttach = ((uint)(5));
			w17.BottomAttach = ((uint)(6));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment2.Add (this.table2);
			this.frame1.Add (this.GtkAlignment2);
			this.GtkLabel2 = new global::Gtk.Label ();
			this.GtkLabel2.Name = "GtkLabel2";
			this.GtkLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>General</b>");
			this.GtkLabel2.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel2;
			this.vbox3.Add (this.frame1);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.frame1]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			w1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox3]));
			w21.Position = 0;
			// Internal child BlinkStickClient.EditNotificationDialog.ActionArea
			global::Gtk.HButtonBox w22 = this.ActionArea;
			w22.Name = "dialog1_ActionArea";
			w22.Spacing = 10;
			w22.BorderWidth = ((uint)(5));
			w22.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w23 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w22 [this.buttonCancel]));
			w23.Expand = false;
			w23.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			w22.Add (this.buttonOk);
			global::Gtk.ButtonBox.ButtonBoxChild w24 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w22 [this.buttonOk]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 309;
			this.DefaultHeight = 373;
			this.Show ();
			this.buttonEditPatterns.Clicked += new global::System.EventHandler (this.OnButtonEditPatternsClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
