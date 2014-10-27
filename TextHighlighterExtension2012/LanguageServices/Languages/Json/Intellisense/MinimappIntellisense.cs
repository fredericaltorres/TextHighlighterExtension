/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.Language.Intellisense;
using DynamicSugar;

namespace jsonB
{
    public class MinimappIntellisense
    {
        static System.Windows.Media.ImageSource _completionIcon = null;
        static Minimapps.Intellisense MinimappsIntellisense = new Minimapps.Intellisense();

        static List<Completion> _completionListOfIds = null;

        public static List<Completion> GetCompletionListOfIds()
        {
            if (_completionListOfIds != null)
                return _completionListOfIds;

            var completions = new List<Completion>();
            _completionListOfIds = completions;

            if (_completionIcon == null)
                _completionIcon = Util.Utility.GetBitmapImage("json.png");

            foreach (var def in MinimappsIntellisense.IDs.Values)
            {
                completions.Add(new Completion()
                {
                    DisplayText = def[0].DisplayText,
                    InsertionText = def[0].InsertionText,
                    Description = def[0].Description,
                    IconSource = _completionIcon,
                    IconAutomationText = "IconAutomationText"
                });
            }
            return completions;
        }

        public static List<Completion> GetCompletionForId(string minimappId)
        {       
            var completions = new List<Completion>();

            if (_completionIcon == null)
                _completionIcon = Util.Utility.GetBitmapImage("json.png");

            if (MinimappsIntellisense.WhenActivatedDef.ContainsKey(minimappId))
            {
                var defs = MinimappsIntellisense.WhenActivatedDef[minimappId];

                foreach (var def in defs)
                {
                    completions.Add(new Completion()
                    {
                        DisplayText = def.DisplayText,
                        InsertionText = ": "+ def.InsertionText,
                        Description = def.Description,
                        IconSource = _completionIcon,
                        IconAutomationText = "IconAutomationText"
                    });
                }
            }
            return completions;
        }
    }
}
*/