﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizTool.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("QuizTool.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //IMPORTANT INFORMATION: READ THIS!!!
        /////You must run the program ONCE to encrypt this txt file so it is not readable by students.
        /////Do NOT change the filename of Quiz.txt.
        /////Syntax Examples
        ///
        /////Define Title
        ///Title:&quot;Mathematics Operators and Sequence Pt.1&quot;
        ///
        /////Option1
        ///Question:&quot;What is 2+3?&quot; A:&quot;5&quot; B:&quot;7&quot; C:&quot;8&quot; D:&quot;10&quot; Answer:&quot;5&quot;
        ///
        /////Option2
        ///Question:&quot;What is 5*3?&quot; &quot;5&quot; &quot;10&quot; &quot;20&quot; &quot;15&quot; &quot;15&quot;
        ///Question:&quot;What is 10^3?&quot; &quot;500&quot; &quot;100&quot; &quot;1000&quot; &quot;10000&quot; &quot;1000&quot;
        ///
        /////Option3
        ///Q &quot;What is (10-3)*2?&quot; &quot;8&quot; &quot;9&quot; &quot;15&quot; &quot;14&quot; &quot;1 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Quiz_Template___READ_ME {
            get {
                return ResourceManager.GetString("Quiz_Template___READ_ME", resourceCulture);
            }
        }
    }
}
