namespace KittyGo.Properties
{
    using System;

    /// <summary>
    ///   Ресурсы проекта (картинки из папки Resources).
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources
    {
        private static global::System.Resources.ResourceManager resourceMan;
        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KittyGo.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        internal static System.Drawing.Bitmap background {
            get {
                object obj = ResourceManager.GetObject("background", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        internal static System.Drawing.Bitmap coin {
            get {
                object obj = ResourceManager.GetObject("coin", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        internal static System.Drawing.Bitmap door_closed {
            get {
                object obj = ResourceManager.GetObject("door_closed", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        internal static System.Drawing.Bitmap door_open {
            get {
                object obj = ResourceManager.GetObject("door_open", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        internal static System.Drawing.Bitmap key1 {
            get {
                object obj = ResourceManager.GetObject("key1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        internal static System.Drawing.Bitmap platform1 {
            get {
                object obj = ResourceManager.GetObject("platform1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }

        internal static System.Drawing.Bitmap player11 {
            get {
                object obj = ResourceManager.GetObject("player11", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
