
// This file has been generated by the GUI designer. Do not modify.
namespace LuaBinding
{
	internal partial class CompilerParametersPanelWidget
	{
		private global::Gtk.Table MainTable;
		private global::Gtk.Entry Arguments;
		private global::Gtk.Label label1;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.ComboBox LanguageVersion;
		private global::Gtk.Entry MainFileEntry;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LuaBinding.CompilerParametersPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LuaBinding.CompilerParametersPanelWidget";
			// Container child LuaBinding.CompilerParametersPanelWidget.Gtk.Container+ContainerChild
			this.MainTable = new global::Gtk.Table (((uint)(3)), ((uint)(2)), false);
			this.MainTable.Name = "MainTable";
			this.MainTable.RowSpacing = ((uint)(6));
			this.MainTable.ColumnSpacing = ((uint)(6));
			// Container child MainTable.Gtk.Table+TableChild
			this.Arguments = new global::Gtk.Entry ();
			this.Arguments.CanFocus = true;
			this.Arguments.Name = "Arguments";
			this.Arguments.IsEditable = true;
			this.Arguments.WidthChars = 27;
			this.Arguments.InvisibleChar = '●';
			this.MainTable.Add (this.Arguments);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.MainTable [this.Arguments]));
			w1.TopAttach = ((uint)(2));
			w1.BottomAttach = ((uint)(3));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child MainTable.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Lua version");
			this.MainTable.Add (this.label1);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.MainTable [this.label1]));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child MainTable.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Additional arguments");
			this.MainTable.Add (this.label2);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.MainTable [this.label2]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child MainTable.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Main file");
			this.MainTable.Add (this.label3);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.MainTable [this.label3]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child MainTable.Gtk.Table+TableChild
			this.LanguageVersion = global::Gtk.ComboBox.NewText ();
			this.LanguageVersion.Name = "LanguageVersion";
			this.MainTable.Add (this.LanguageVersion);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.MainTable [this.LanguageVersion]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child MainTable.Gtk.Table+TableChild
			this.MainFileEntry = new global::Gtk.Entry ();
			this.MainFileEntry.CanFocus = true;
			this.MainFileEntry.Name = "MainFileEntry";
			this.MainFileEntry.IsEditable = true;
			this.MainFileEntry.InvisibleChar = '●';
			this.MainTable.Add (this.MainFileEntry);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.MainTable [this.MainFileEntry]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.MainTable);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
