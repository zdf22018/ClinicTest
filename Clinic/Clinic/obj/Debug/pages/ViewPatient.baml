   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Clinic.pagesClinic.pages  5      > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null&clr-namespace:DAL;assembly=DALDAL 5          Clinic.pages.ViewPatient   5      a ]DevExpress.Xpf.Core.v17.2, Version=17.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Clinic.pages     5      .DALclr-namespace:DAL;assembly=DAL     5      -   5          N� Title$  ViewPatient��5	      $
��1200��60   $��771.428��6=    � 	Resources 5         patientViewSource / +display_appointements_for_PatientViewSource��%:   &	        &	      �� 5   
   6   �� 5   
   6   5      .��5      �  � DataContext# [ 6   $��0,0,0,10q�6V   .+�5   
   � -   5         �Name$ grid1��5      $	��Top=�6   $��	32,77,0,0q�66   $
��Left=�6I   # [  6d    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5!      �� $��Center=�6   $��0��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Date Of Birth:��6r   �� 5"      -   5         ��Name$ dateOfBirthTextBox��5"      $	��120��62   $��Center=�6>   $��0��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6Y   �� *DateOfBirth+ �� Mode$ TwoWay=� �� NotifyOnValidationError . 	 �� ValidatesOnExceptions	 . 6�   �� 5#      $��Center=�6   $��1��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Email:��6r   �� 5$      -   5        $ emailTextBox��5$      $	��120��6,   $��Center=�68   $��1��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6S   �� *Email+$ TwoWay=� . 	 . 6�   �� 5%      $��Center=�6   $��2��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��First Name:��6r   �� 5&      -   5        $ firstNameTextBox��5&      $	��120��60   $��Center=�6<   $��2��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6W   �� *	FirstName+$ TwoWay=� . 	 . 6�   �� 5'      $��Center=�6   $��3��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $	��Id:��6r   �� 5(      -   5        
 ��Name$
 idLabel��5(      $��Center=�6%   $��3��6@   $��3q�6M   $
��Left=�6X   $��1��6s   ��6�   �� *Id+�� 5)      $��Center=�6   $��4��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��
Last Name:��6r   �� 5*      -   5        $ lastNameTextBox��5*      $	��120��6/   $��Center=�6;   $��4��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6V   �� *
LastName+$ TwoWay=� . 	 . 6�   �� 5+      $��Center=�6   $��5��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Medical Card No:��6r   �� 5,      -   5        $ medicalCardNoTextBox��5,      $	��120��64   $��Center=�6@   $��5��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6   ��6[   �� *MedicalCardNo+$ TwoWay=� . 	 . 6   �� 5-      $��Center=�6   $��6��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Phone:��6r   �� 5.      -	   5        $ phoneTextBox��5.      $	��120��6,   $��Center=�68   $��6��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6S   �� *Phone+$ TwoWay=� . 	 . 6�   5/      �� 50   
   -
   5         ��Name$ 
btPrevious��50      $��Previous��6&   $
��Left=�69   $��	32,10,0,0q�6T   $	��Top=�6g   $��75��6   6�   �� 51   
   -   5        $ btNext��51      $
��Next��6!   $
��Left=�60   $��
145,10,0,0q�6K   $	��Top=�6_   $��75��6w   6�   &   System.Windows.Controls.DataGrid  52   
   -   5          Name$/ )display_appointements_for_PatientDataGrid��52         AutoGenerateColumns .     EnableRowVirtualization . $��277,77,460,495q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6�   ��  �� Source# [    Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      -   5        appointmentIdColumn��,  &System.Windows.Controls.DataGridColumn   Header$ appointment Id��54   d      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6|   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *appointmentId+6|   4  .System.Windows.Controls.DataGridTemplateColumn  55      -   5        doctorColumn��$ Doctor��55   ?   $	 100 6O      CellTemplate 56      �� 57      .R�58      �� ��6$   �� *Doctor+59      5;        5=      -   5        startColumn��$ Start��5=   >   $	 130 6M    5>      �� 5?      .R�5@      �� ��6$   �� *Start+5A      5C        5D      -   5        	endColumn��$	 End��5D   <   $	 130 6I    5E      �� 5F      .R�5G      �� ��6$   �� *End+5H      5J      5L      5N      5O      