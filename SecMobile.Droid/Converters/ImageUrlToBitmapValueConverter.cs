using System;
using System.Globalization;
using System.Net;
using Android.Graphics;
using MvvmCross.Platform.Converters;

namespace SecMobile.Droid.Converters
{
	public class ImageUrlToBitmapValueConverter : IMvxValueConverter
	{
		public object Convert(object url, Type targetType, object parameter, CultureInfo culture)
		{
			Bitmap imageBitmap = null;
			if (url != null)
			{
				using (var webClient = new WebClient())
				{
					var imageBytes = webClient.DownloadData(url.ToString());
					if (imageBytes != null && imageBytes.Length > 0)
					{
						imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
					}
				}
			}
			return GetRoundedShape(imageBitmap);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		private Bitmap GetRoundedShape(Bitmap scaleBitmapImage)
		{
			int targetWidth = 80;
			int targetHeight = 80;
			Bitmap targetBitmap = Bitmap.CreateBitmap(targetWidth,
				targetHeight, Bitmap.Config.Argb8888);

			Canvas canvas = new Canvas(targetBitmap);
			Android.Graphics.Path path = new Android.Graphics.Path();
			path.AddCircle(((float)targetWidth - 1) / 2,
				((float)targetHeight - 1) / 2,
				(Math.Min(((float)targetWidth),
					((float)targetHeight)) / 2),
				Android.Graphics.Path.Direction.Ccw);

			canvas.ClipPath(path);
			Bitmap sourceBitmap = scaleBitmapImage;
			canvas.DrawBitmap(sourceBitmap,
				new Rect(0, 0, sourceBitmap.Width,
					sourceBitmap.Height),
				new Rect(0, 0, targetWidth, targetHeight), null);
			return targetBitmap;
		}
	}
}