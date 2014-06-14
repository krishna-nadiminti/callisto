﻿﻿//
// Copyright (c) 2013 Morten Nielsen
//
// Licensed under the Microsoft Public License (Ms-PL) (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://opensource.org/licenses/Ms-PL.html
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using Callisto.Design.Common;
using Microsoft.Windows.Design;
using Microsoft.Windows.Design.Metadata;
using Microsoft.Windows.Design.PropertyEditing;
using System.ComponentModel;

namespace Callisto.Design
{
	internal class SettingsFlyoutMetadata : AttributeTableBuilder
	{
		public SettingsFlyoutMetadata()
			: base()
		{
			AddCallback(typeof(Callisto.Controls.SettingsFlyout),
				b =>
				{
					b.AddCustomAttributes("HeaderText",
						new CategoryAttribute(Properties.Resources.CategoryCommon)
					);
					b.AddCustomAttributes("ContentBackgroundBrush",
						new CategoryAttribute(Properties.Resources.CategoryBrush)
					);
					b.AddCustomAttributes("ContentForegroundBrush",
						new CategoryAttribute(Properties.Resources.CategoryBrush)
					);
					b.AddCustomAttributes("HeaderBrush",
						new CategoryAttribute(Properties.Resources.CategoryBrush)
					);
					b.AddCustomAttributes("FlyoutWidth",
						new CategoryAttribute(Properties.Resources.CategoryLayout)
					);
					b.AddCustomAttributes("IsOpen",
						new CategoryAttribute(Properties.Resources.CategoryCommon)
					);
					b.AddCustomAttributes("SmallLogoImageSource",
						new CategoryAttribute(Properties.Resources.CategoryCommon)
					);
                    b.AddCustomAttributes(new ToolboxCategoryAttribute(ToolboxCategoryPaths.Callisto, false));
				}
			);
		}
	}
}
