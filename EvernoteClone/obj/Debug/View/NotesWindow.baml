   M S B A M L   `   `   `  ����H  DEvernoteClone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:EvernoteClone.ViewEvernoteClone.View  5   	   A%clr-namespace:EvernoteClone.ViewModelEvernoteClone.ViewModel  5   	   $    EvernoteClone.View.NotesWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:EvernoteClone.View     5   	   4vm%clr-namespace:EvernoteClone.ViewModel     5   	     � Title$  NotesWindow��5	      $	��400��6   $	��600��6)    � 	Resources 5      %   EvernoteClone.ViewModel.NotesVM   vm��%   &	          5   
   6   5      .��5      ]�  � DataContext# [  6   .+�5   
   o� $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� $��New notebook��6    m� Command 5      �� *NewNoteBookCommand+m� 5      $��New note��6    5      �� *NewNoteCommand+ m� CommandParameter 5      �� *SelectedNoteBook+�� 5      m� 5      -   5        $
��Exit��5      5      5      5      �� 5   
   $��Bottom=�6   .@�5      �� .��5      �� -   5         ��Name$ statusTextBlock��5      5       5!      �� 5#   
   $
��Left=�6   $	��140��5$       �� SelectedItem 5%      �� *SelectedNoteBook+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���5&      �� *	NoteBooks+��5'      �� 5(      .R�5)      �� ��6    �� *Name+5*      5,      �� 5.   
   $
��Left=�6   $	��140��5/      ��50      �� *Notes+��51      �� 52      .R�53      �� ��6    �� *Title+54      56      `� 58   
   $	��Top=�6   .�59      c� .@�5:      �� -   5        $��Speech��5:      5;      d� 5<      -   5        	 d�Name$	 
boldButton��5<      .��5>      �� $��B��6    $
��Bold"�5?       5A      d� 5C      -   5        $	 italicButton��5C      .��5E      �� $��I��6    $��Italic$�5F       5H      d� 5J      -   5        $	 underlineButton��5J      .��5L      �� $��B��6    $��	Underline{�5M       5O      5Q      5R      � 5T   
   .+�5U      �� -   5        
 ��Name$
 contentRichTextBox��5U      5W      5X      5Z      5[      