   M S B A M L   `   `   `  ����J  FWPFLibraryAdmin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WPFLibraryAdminWPFLibraryAdmin  5   	       WPFLibraryAdmin.Window1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WPFLibraryAdmin     5   	     � Title$  Window1��5   	   $��395.333��6   $	��300��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ listBox��5      $
��Left=�6#   $	��115��6>   $��
10,198,0,0q�6K   $	��Top=�6_   $	��272��6w   �� 5   
   -   5         ��Name$ tbxTitle��5      $
��Left=�6$   $��20��6?   $��106,135,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $��Title��6t   $	��Top=�6�   $	��157��6�   �� 5   
   -   5        $ 	txbAuthor��5      $
��Left=�6%   $��23��6@   $��106,162,0,0q�6L   $
 Wrap=�6a   $��Author��6u   $	��Top=�6�   $	��157��6�   �� 5   
   -   5         ��Name$ lblTitle��5      $��Title: ��6"   $
��Left=�64   $��
35,131,0,0q�6O   $	��Top=�6c   $��66��6{   $��24��6�   �� 5   
   -   5        $ 	lblAuthor��5      $��Author: ��6#   $
��Left=�66   $��
35,160,0,0q�6Q   $	��Top=�6e   $��66��6}   $��24��6�   �� 5   
   -   5         ��Name$ 	btnSearch��5      $��Search��6$   $
��Left=�65   $��198,324,0,0q�6P   $	��Top=�6e   $��75��6}    J� RenderTransformOrigin$ 2.631,0.576&�6�   $��22��6�   �� 5   
   -   5        $ btnClose��5      $��Close��6#   $
��Left=�63   $��
45,324,0,0q�6N   $	��Top=�6b   $��75��6z   $��22��6�   �� 5   
   -   5        $ lblLanguage��5      $��Language��6%   $
��Left=�68   $��
35,102,0,0q�6S   $	��Top=�6g   $��66��6   $��24��6�   �� 5   
   -	   5        $ lblCategory��5      $��Category��6%   $
��Left=�68   $��	35,75,0,0q�6S   $	��Top=�6f   $��66��6~   $��24��6�   �� 5   
   -
   5        $ 
lblLibrary��5      $��Library��6$   $
��Left=�66   $��	35,47,0,0q�6Q   $	��Top=�6d   $��66��6|   $��24��6�   �� 5   
   -   5        $ 	lblFormat��5      $��Format ��6#   $
��Left=�65   $��	35,20,0,0q�6P   $	��Top=�6c   $��66��6{   $��24��6�   �� 5   
   -   5         ��Name$ cbxLanguage��5      $
��Left=�6(   $��106,104,0,0q�6C   $	��Top=�6X   $	��157��6p   �� 5   
   -   5        $ cbxCategory��5      $
��Left=�6(   $��
106,77,0,0q�6C   $	��Top=�6W   $	��157��6o   �� 5   
   -   5        $ 
cbxLibrary��5      $
��Left=�6'   $��
106,50,0,0q�6B   $	��Top=�6V   $	��157��6n   6z   �� 5   
   -   5        $ 	cbxFormat��5      $
��Left=�6&   $��
106,23,0,0q�6A   $	��Top=�6U   $	��157��6m   6y   5      5       