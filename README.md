Asm6800 

This is a simple text editor written in Visual Studio C# with working tabstops set to code in Assembly.

Press tab for an instruction, tab for the operands, and an final tab for comments.  I provided enough distance for my liking but it could be changed by editing the tabspot distance, see code below.

I did not attempt to make this application adjustable for everyone's setup, it's up to the user to DL the source code and change it with Visual Studio to fit their needs. 

The editor can have two files open with a slider between them plus a text box at the bottom for compiler output.  

Click on the TabControl Tab to set the left or right tab names to set the current editor window to be the target of open and close.

I had to use a placeholder tab name prior to opening files, it was a simple work around.  

It could have contained the code necessary to drag an editor to set file's position in the app space the same as Visual Studio, I didn't hassle with this technique.

The menu bar contains a File section for opening and closing files, an Edit menu for find, and an Action menu for Compile and Run.  

I added a feature under the Edit menu to attempt to remove and replace tabs of files edited with an editor such as NotePad++ where it required inserting several tabs to align the Assembly code.

I added line numbers to the editor, it required adding a separate window to display them next to the source code.  The line number contains 5 digits which is good for source containing up to 99,999 lines of code.

I added double click to the compiler output window at the bottom to advance the editor to the line of code with the error but this function is also hard coded to the compiler I use shown below. I just now realized this won't work on included files.

I used RichTextBox because tabstops are implemented properly. The simpler TextBox control which most editors use does not support the positioning by pixels of tabstops.

I'm not sure what will happen if text formating is added to the program's edit controls, so insert formatting at your own risk, as long as the compiler doesn't mind it might work?

The editor color scheme is white on black, it can be changed in the MainWnd's definition area.

To change the pixel distance between tabs edit the class PanelEditor class contructor method. The line of code for my layout is shown below.

TextCtrl.SelectionTabs = new int[]{200, 300, 500}; 

I did not add a way to change which compiler is used since the parameters would be different so it's up to you to change the code to fit your compiler and drive/folder layout.

Here is the code used to compile:
```
 exe = "e:\\Assembler\\vbcc\\bin\\vasmm68k_mot.exe";
 src = '\"' + tpa.Path + '\"';
 obj = " -Ftos -o " + '\"' + "e:\\Assembler\\Run\\" + tpa.FileNameSansExt + ".TOS" + '\"';
 listout = "-L " + '\"' + "e:\\Assembler\\Listout\\" + tpa.FileNameSansExt + ".txt" + '\"';
```
And the code to run:
```
 exe = "e:\\Assembler\\hatari\\hatari.exe";
 obj = "e:\\Assembler\\Run\\" + tpa.FileNameSansExt + ".TOS" + '\"';
```
 It's hard coded it to work with my hard drive letter and folder setup.

 My C# source code is not aligned to the Microsoft standard. Years ago in 2003 I decided to align C# the same style as my C++ code. It has not been easy since Microsoft typically forces alignment to it's own standard.  I also do not place the opening brace { at the end of method declarations,  this is a very old habit of mine that I started doing back in the 1990s, I thought it looked better to code like this:
```
void methodOfMine()
 {
  code
 }
```

 
