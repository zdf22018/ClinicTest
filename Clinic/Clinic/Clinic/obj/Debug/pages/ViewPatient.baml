   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Clinic.pagesClinic.pages  5      > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null&clr-namespace:DAL;assembly=DALDAL 5          Clinic.pages.ViewPatient   5      a ]DevExpress.Xpf.Core.v17.2, Version=17.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Clinic.pages     5      .DALclr-namespace:DAL;assembly=DAL     5      -   5          N� Title$  ViewPatient��5	      $��999.286��60   $��771.428��6@    � 	Resources 5         patientViewSource ! patientappointmentsViewSource �� Source �� Source��%]   &	        &	      7   �� 5   
   6   �� 5   
    6E   �� *appointments+8   5      .��5      �  � DataContext# [ 6   $��0,0,0,10q�6H   .+�5   
   � -   5         �Name$ grid1��5      $	��Top=�6   $��	32,77,0,0q�66   $
��Left=�6I   # [  6d    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5       �� $��Center=�6   $��0��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Date Of Birth:��6r   �� 5!      -   5         ��Name$ dateOfBirthTextBox��5!      $	��120��62   $��Center=�6>   $��0��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6Y   �� *DateOfBirth+	 �� Mode$	 TwoWay=�
 �� NotifyOnValidationError
 .  �� ValidatesOnExceptions . 6�   �� 5"      $��Center=�6   $��1��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Email:��6r   �� 5#      -   5        $ emailTextBox��5#      $	��120��6,   $��Center=�68   $��1��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6S   �� *Email+$	 TwoWay=�
 .  . 6�   �� 5$      $��Center=�6   $��2��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��First Name:��6r   �� 5%      -   5        $ firstNameTextBox��5%      $	��120��60   $��Center=�6<   $��2��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6W   �� *	FirstName+$	 TwoWay=�
 .  . 6�   �� 5&      $��Center=�6   $��3��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $	��Id:��6r   �� 5'      -   5         ��Name$ idLabel��5'      $��Center=�6%   $��3��6@   $��3q�6M   $
��Left=�6X   $��1��6s   ��6�   �� *Id+�� 5(      $��Center=�6   $��4��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��
Last Name:��6r   �� 5)      -   5        $ lastNameTextBox��5)      $	��120��6/   $��Center=�6;   $��4��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6V   �� *
LastName+$	 TwoWay=�
 .  . 6�   �� 5*      $��Center=�6   $��5��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Medical Card No:��6r   �� 5+      -   5        $ medicalCardNoTextBox��5+      $	��120��64   $��Center=�6@   $��5��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6   ��6[   �� *MedicalCardNo+$	 TwoWay=�
 .  . 6   �� 5,      $��Center=�6   $��6��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Phone:��6r   �� 5-      -	   5        $ phoneTextBox��5-      $	��120��6,   $��Center=�68   $��6��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�   ��6S   �� *Phone+$	 TwoWay=�
 .  . 6�   5.      �� 5/   
   $��Button��6   $
��Left=�6"   $��	32,10,0,0q�6=   $	��Top=�6P   $��75��6h   �� 50   
   $��Button��6   $
��Left=�6"   $��
145,10,0,0q�6=   $	��Top=�6Q   $��75��6i   � 51   
   -
   5        $ grid2��51      $
��Left=�6   $��437,109,0,0q�69   $	��Top=�6N   $	��160��6f    52      �� 53      $��54.786 �6#   �� 54      $��37.214 �6#   �� 55      $
��Auto �6#    57      �� 58      $
��Auto �6    �� 59      �� 5:      $
��Auto �6    �� 5;      $
��Auto �6    .+�5=      �� $��Is Available:��6   $��0��6,   $
��Left=�6<   $��3,3,0,3q�6W   $��0��6h   $��Center=�6u   $��2��6�   �� 5>      -   5         ��Name$ isAvailableCheckBox��5>      $�� ��64   $��2��6?   $
��Left=�6O   $��3,8,0,8q�6�   $��0��6�   $��Center=�6�    d� 	IsChecked 6j   �� *timeslot.IsAvailable+$	 TwoWay=�
 .  . 6�   �� 5?      $��Slot Doctor Id:��6   $��0��6.   $
��Left=�6>   $��3,3,0,3q�6Y   $��1��6j   $��Center=�6w   $��2��6�   �� 5@      -   5        $ slotDoctorIdTextBox��5@      $��2��63   $
��Left=�6C   $��24��6^   $��3,4,0,4q�6j   $��1��6{   $��Center=�6�   $	��120��6  ��6�   �� *timeslot.SlotDoctorId+$	 TwoWay=�
 .  . 6  �� 5A      $��	Slot End:��6   $��0��6(   $
��Left=�68   $��3,3,0,3q�6S   $��2��6d   $��Center=�6q   $��2��6�   �� 5B      -   5        $ slotEndTextBox��5B      $��2��6.   $
��Left=�6>   $��24��6Y   $��3,4,0,4q�6e   $��2��6v   $��Center=�6�   $	��120��6  ��6�   �� *timeslot.SlotEnd+$	 TwoWay=�
 .  . 6  �� 5C      $��Slot Start:��6   $��0��6*   $
��Left=�6:   $��3,3,0,3q�6U   $��3��6f   $��Center=�6s   $��2��6�   �� 5D      -   5        $ slotStartTextBox��5D      $��2��60   $
��Left=�6@   $��24��6[   $��3,4,0,4q�6g   $��3��6x   $��Center=�6�   $	��120��6  ��6�   �� *timeslot.SlotStart+$	 TwoWay=�
 .  . 6  5E      5G      5H      