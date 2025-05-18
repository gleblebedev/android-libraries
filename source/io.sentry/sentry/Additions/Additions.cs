using System;

namespace IO.Sentry
{
	public partial class SentryInstantDate
	{
		public override int CompareTo (global::Java.Lang.Object other)
		{
			return (int) this.Diff ((SentryDate) other);
		}
	}
	public partial class SentryLongDate
	{
		public override int CompareTo (global::Java.Lang.Object other)
		{
			return (int) this.Diff ((SentryDate) other);
		}
	}
	public partial class SentryNanotimeDate
	{
		public override int CompareTo (global::Java.Lang.Object other)
		{
			return (int)this.Diff ((SentryDate) other);
		}
	}
}
