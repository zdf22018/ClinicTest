   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Clinic.pagesPatientClinic.pagesPatient  5      > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null&clr-namespace:DAL;assembly=DALDAL 5      '    !Clinic.pagesPatient.PatientDetail   5      a ]DevExpress.Xpf.Core.v17.2, Version=17.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Clinic.pagesPatient     5      .DALclr-namespace:DAL;assembly=DAL     5      -   5          N� Title$  PatientDetail��5
       � 	Resources 5         patientViewSource��%   &	        �� 5   
   6   5      .��5      � .+�5   
   �� -   5         ��Name$ btUPdate��5      $��Update��6#   $
��Left=�64   $��412,137,0,0q�6O   $	��Top=�6d   $��75��6|   6�   � 5   
   -   5         �Name$ grid1��5       � DataContext# [  6   $
��Left=�6O   $��	58,48,0,0q�6j   $	��Top=�6}    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    .+�5#      �� $��Date Of Birth:��6   $��0��6-   $
��Left=�6=   $��3q�6X   $��0��6c   $��Center=�6p   �� 5$      -   5         ��Name$ dateOfBirthTextBox��5$      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��0��6t   $��Center=�6�   $	��120��6   ��6�   �� *DateOfBirth+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . 6   �� 5%      $��Email:��6   $��0��6%   $
��Left=�65   $��3q�6P   $��1��6[   $��Center=�6h   �� 5&      -   5        $ emailTextBox��5&      $��1��6,   $
��Left=�6<   $��23��6W   $��3q�6c   $��1��6n   $��Center=�6�   $	��120��6�   ��6{   �� *Email+$ TwoWay=�	 . 
 . 6�   �� 5'      $��First Name:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��2��6`   $��Center=�6m   �� 5(      -   5        $ firstNameTextBox��5(      $��1��60   $
��Left=�6@   $��23��6[   $��3q�6g   $��2��6r   $��Center=�6�   $	��120��6�   ��6   �� *	FirstName+$ TwoWay=�	 . 
 . 6�   �� 5)      $	��Id:��6   $��0��6"   $
��Left=�62   $��3q�6M   $��3��6X   $��Center=�6e   �� 5*      -   5         ��Name$ idLabel��5*      $��1��6<   $
��Left=�6L   $��3q�6g   $��3��6r   $��Center=�6   ��6%   �� *Id+6   �� 5+      $��
Last Name:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��4��6_   $��Center=�6l   �� 5,      -   5        $ lastNameTextBox��5,      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��4��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
LastName+$ TwoWay=�	 . 
 . 6�   �� 5-      $��Login Pass Word:��6   $��0��6/   $
��Left=�6?   $��3q�6Z   $��5��6e   $��Center=�6r   �� 5.      -	   5        $ loginPassWordTextBox��5.      $��1��64   $
��Left=�6D   $��23��6_   $��3q�6k   $��5��6v   $��Center=�6�   $	��120��6  ��6�   �� *LoginPassWord+$ TwoWay=�	 . 
 . 6  �� 5/      $��Medical Card No:��6   $��0��6/   $
��Left=�6?   $��3q�6Z   $��6��6e   $��Center=�6r   �� 50      -
   5        $ medicalCardNoTextBox��50      $��1��64   $
��Left=�6D   $��23��6_   $��3q�6k   $��6��6v   $��Center=�6�   $	��120��6  ��6�   �� *MedicalCardNo+$ TwoWay=�	 . 
 . 6  �� 51      $��Phone:��6   $��0��6%   $
��Left=�65   $��3q�6P   $��7��6[   $��Center=�6h   �� 52      -   5        $ phoneTextBox��52      $��1��6,   $
��Left=�6<   $��23��6W   $��3q�6c   $��7��6n   $��Center=�6�   $	��120��6�   ��6{   �� *Phone+$ TwoWay=�	 . 
 . 6�   �� 53      $��
User Name:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��8��6_   $��Center=�6l   �� 54      -   5        $ userNameTextBox��54      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��8��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
UserName+$ TwoWay=�	 . 
 . 6�   55      56      57      