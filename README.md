# Maslime
A text editor for masm files(.asm) used for editing 8086 ALP

Currently is just another text editor with very low functionality.
Possesses the functions like (cut, copy, paste, save, exit, open*, handling the arrow keys and other keys*)
tab key is unsupported yet
The Branch - Button_color_change has an additional functionality to change the color of =
The new commit supports ADD,add,MOV,mov and , for a color change on click of bubtton

------issues-------
the inbuild function is only meant to return the index value of first occurance of a word. And I've used that . So, only the first appearance of the keywork will have a color change on Click of the button.
------solition-----
Dont have enough time today to study the Text class, to build a funtion to return a array of index of occurances.
maintaining such array of accurances will solve color change for multiple occurances.

Multithreading will be the answer to real-time color changing and I have no intentions of doing that.

------------------
This is not a fully compelete ALText editor. Feel free to play with it.
 -*- not tested


Developed by using C#
--by ajHash
