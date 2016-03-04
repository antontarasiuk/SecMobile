using System;
using System.Collections.Concurrent;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Android.Content;
using Android.Graphics;
using Android.Util;
using Android.Widget;
using OperationCanceledException = Android.Accounts.OperationCanceledException;

namespace SecMobile.Droid.Controls
{
	public class SpecialMvxImageView : ImageView
	{
		private string _specialImageUrl;
		private static readonly ConcurrentDictionary<string, Task<Bitmap>> BitmapCache = new ConcurrentDictionary<string, Task<Bitmap>>();
		private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

		public SpecialMvxImageView(Context context, IAttributeSet attrs)
			: base(context, attrs)
		{
		}

		public SpecialMvxImageView(Context context)
			: base(context)
		{
		}

		public string SpecialImageUrl
		{
			get { return _specialImageUrl; }
			set
			{
				SetImageToDefault();
				if (!string.IsNullOrEmpty(value))
				{
					_specialImageUrl = value;
					StartImageDownloading(value, _cancellationTokenSource.Token);
				}
			}
		}

		private void SetImageToDefault()
		{
			_cancellationTokenSource.Cancel();
			_cancellationTokenSource = new CancellationTokenSource();
			//SetImageResource(Resource.Drawable.ic_defaultavatar);
		}

		private async void StartImageDownloading(string uri, CancellationToken cancellationToken = default(CancellationToken))
		{
			try
			{
				Task<Bitmap> bmpTask;
				lock (BitmapCache)
				{
					if (!BitmapCache.TryGetValue(uri, out bmpTask))
					{
						BitmapCache[uri] = bmpTask = DownloadImageDataAsync(uri);
					}
				}

				var bmp = await bmpTask;
				cancellationToken.ThrowIfCancellationRequested();
				SetImageBitmap(bmp);
			}
			catch (OperationCanceledException) { }
			catch (Exception)
			{
				//do nothing, invalid avatar
			}
		}

		public async static Task<Bitmap> DownloadImageDataAsync(string uri, CancellationToken cancellationToken = default(CancellationToken))
		{
			cancellationToken.ThrowIfCancellationRequested();
			if (string.IsNullOrWhiteSpace(uri))
				return null;

			byte[] content;

			var client = (HttpWebRequest)WebRequest.Create(uri);
			var response = await client.GetResponseAsync();

			cancellationToken.ThrowIfCancellationRequested();

			using (var responseStream = response.GetResponseStream())
			using (var reader = new BinaryReader(responseStream))
			{
				content = reader.ReadBytes((int)responseStream.Length);
			}
			Bitmap bmp = await BitmapFactory.DecodeByteArrayAsync(content, 0, content.Length);

			cancellationToken.ThrowIfCancellationRequested();

			return bmp;
		}
	}
}