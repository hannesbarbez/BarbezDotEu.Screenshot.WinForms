# BarbezDotEu.Screenshot.WinForms (a.k.a. Screenshot One Pro)
Repository for the Screenshot One Pro application in the Microsoft Store.

Screenshot One Pro takes awesome, whole webpage screenshots in batch.

Screenshot One Pro makes full-length screenshots of webpages much larger than your screen resolution – in batch! It’s straight-forward, and does not contain advertisements!

Enjoy its batch functionality: Submit an entire list of webpages and, with one click, Screenshot One Pro will make screenshots of all pages in the list! The length and width of each screenshot is fully customizable.

Save as PNG, GIF or JPG/JPEG. You can add a PNG or GIF watermark from anywhere on the web, and give each snapshot a custom file name.

# Features
- Create bulk screenshots of a list of webpages (or just one).
- Submit an entire list of webpages and, with one click, Screenshot One Pro will make batch screenshots of all pages in the list!
- Capture gigantic screenshots – Larger than your device, up to 99,999 pixels long and up to 9,999 pixels wide!
- Save your screen captures in FIVE different file formats: PNG, JPEG, GIF, TIFF and BMP. Lossy or lossless, it’s up to you.
- Choose from a wide range of phone, tablet, laptop, and desktop pc resolution presets: They accurately reflect different types of devices but any combination is possible.
- Easely add a watermark of your choice – Both GIF and PNG are supported.
- Screenshot One Pro is a compact app: a limited amount of memory and storage are enough to install the app!
- Perform batch screenshotting in a fully-automated way by using the app command line (CLI) switches in your own Batch or PowerShell scripts
- Easy to use and understand! Make it as complex as you wish.
- Automatically name a screenshot based on the URL
- Ability to emulate different Trident Internet Explorer modes and see how that can affect a certain website’s UX (user experience)
- Completely multi-threaded
- Custom file output folder
- Facilitation of common post-screenshot tasks: copy the resulting file path to clipboard, openthe containing folder so you can move it elsewhere, show the screenshot in your favorite viewer, and more.
- Private: Screenshots render locally, there is NO data collection done by the the Screenshot One Pro app.

# Example use cases
- You need to render a batch of screenshots and want to automate the process with a couple of clicks.
- You design webpages and want to showcase a macro view of your design.
- To save a visual snapshot of a website for future reference: see how a site looked at a specific point in time.
- As a base for a graphic design work in which you capture the awesome lay-out of your website.
- Screenshots of a product page in an online shop, or of many pages on one domain.

# Binaries
https://www.microsoft.com/p/screenshot-one-pro/9nsspdbx83lh

# Usage
1. Paste or type the URL of a website or the path of a file you want to take a snapshot of (or use the batch feature to capture an entire list of webpages).
2. Choose a custom resolution or select one of the presets to define the resolution of the snapshot.
3. If you want: select a file type and name your snapshot. Also: Paste or type the URL to a watermark on the web.
4. The web capture is now saved to your picture gallery. Screenshot One Pro can now open the app of your choice to share or edit the image.

# CLI / PowerShell script use
All switches are optional, but the more you use, the higher the potential degree of automation. Please note, that the order in which the CLI switches are used is currently important in relation to the correct operation of the software. If you choose to use the -m switch (watermark), it always has to be the last switch in line.

## Schematic example
> ScreenshotOnePro -t [PNG, JPEG, GIF, TIFF or BMP] -u [URL] -h [height] -w [width] -d Y -v [IE emul. version & mode] -r [naming reference] -l [Full path to desired output folder] -m [full path to watermark file]

## Real-life example
> ScreenshotOnePro -t PNG -u "https://www.microsoft.com/store/apps/9MT9H8PTP897" -h 20000 -w 1000 -v (Latest) -d Y -l "C:\example" -r "GeneratedByScreenshotOnePro"

where:

-t : file format for the output file: PNG, JPEG, GIF, TIFF or BMP;
-u : url of the website to make a screen capture of;
-h : height of screenshot in pixels;
-w : width of screenshot in pixels;
-d Y : auto-execute command or omit if the “Render Screenshot” button needs to be invoked manually;
-v : version and mode of Internet Explorer emulation (see below for options);
-r : reference for naming the resulting file name;
-l : full path to desired output folder;
-m : path to an optional watermark picture.

# IE Version and Mode Emulation options (CLI -v switch)
The currently available versions and modes for the Trident IE mode switch -v are listed here. Not all might be available on all computers, as this depends greatly on the Windows version used and the updates installed.

-v (Latest) : Will attempt to use the most recent IE version and mode (11 “Edge” User Agent String);
-v 11QuirksMode : IE version 11 in Quirks mode;
-v 11EdgeMode : IE v11 in Edge mode;
-v 10QuirksMode : IE v10 in Quirks mode;
-v 10StandardsMode : IE v10 in Standards-compliance mode;
-v 9QuirksMode : IE 9 – Quirks;
-v 9StandardsMode : IE 9 – Standards;
-v 8QuirksMode : IE 8 – Quirks;
-v 8StandardsMode : IE 8 – Standards; -v 7 : IE v7.

# Versions
See versions.txt

# Technology
WinForms, C#, .NET

