﻿
namespace FieldSuite.Placeholders.Types
{
	public class FieldId : IFieldPlaceholder
	{
		/// <summary>
		/// Returns Field Placeholder Value
		/// </summary>
		/// <param name="args"></param>
		/// <returns></returns>
		public string Execute(FieldPlaceholderArgs args)
		{
			if (args == null || string.IsNullOrEmpty(args.ClickEvent) || string.IsNullOrEmpty(Key) || string.IsNullOrEmpty(args.FieldId))
			{
				return string.Empty;
			}

			string clickEvent = args.ClickEvent;
			clickEvent = clickEvent.Replace(Key, args.FieldId);

			return clickEvent;
		}

		/// <summary>
		/// Key
		/// </summary>
		public string Key
		{
			get;set;
		}
	}
}