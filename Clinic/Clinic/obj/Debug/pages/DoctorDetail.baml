   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClinicClinic  5      > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null&clr-namespace:DAL;assembly=DALDAL 5          Clinic.DoctorDetail   5      a ]DevExpress.Xpf.Core.v17.2, Version=17.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Clinic     5      .DALclr-namespace:DAL;assembly=DAL     5      -   5          N� Title$  DoctorDetail��5
       � 	Resources 5         doctorViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   $��0,0,10,0q�6;   .+�5   
   �� -   5         ��Name$ btUpdate��5      $��Update��6#   $
��Left=�64   $��403,356,0,0q�6O   $	��Top=�6d   $��75��6|   6�   � 5   
   -   5         �Name$ gridDoctorDetail��5      $
��Left=�6)   $��	98,68,0,0q�6D   $	��Top=�6W    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    .+�5$      �� $��Email:��6   $��0��6%   $
��Left=�65   $��3q�6P   $��0��6[   $��Center=�6h   �� 5%      -   5         ��Name$ emailTextBox��5%      $��1��6,   $
��Left=�6<   $��23��6W   $��3q�6c   $��0��6n   $��Center=�6�   $	��120��6�   ��6{   �� *Email+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . 6�   �� 5&      $��First Name:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��1��6`   $��Center=�6m   �� 5'      -   5        $ firstNameTextBox��5'      $��1��60   $
��Left=�6@   $��23��6[   $��3q�6g   $��1��6r   $��Center=�6�   $	��120��6�   ��6   �� *	FirstName+$ TwoWay=�	 . 
 . 6�   �� 5(      $��
Full Name:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��2��6_   $��Center=�6l   �� 5)      -   5        $ fullNameTextBox��5)      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��2��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
FullName+$ TwoWay=�	 . 
 . 6�   �� 5*      $	��Id:��6   $��0��6"   $
��Left=�62   $��3q�6M   $��3��6X   $��Center=�6e   �� 5+      -   5         ��Name$ idLabel��5+      $��1��6<   $
��Left=�6L   $��3q�6g   $��3��6r   $��Center=�6   ��6%   �� *Id+6   �� 5,      $��
Last Name:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��4��6_   $��Center=�6l   �� 5-      -   5        $ lastNameTextBox��5-      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��4��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
LastName+$ TwoWay=�	 . 
 . 6�   �� 5.      $��Login Pass Word:��6   $��0��6/   $
��Left=�6?   $��3q�6Z   $��5��6e   $��Center=�6r   �� 5/      -	   5        $ loginPassWordTextBox��5/      $��1��64   $
��Left=�6D   $��23��6_   $��3q�6k   $��5��6v   $��Center=�6�   $	��120��6  ��6�   �� *LoginPassWord+$ TwoWay=�	 . 
 . 6  �� 50      $��Phone:��6   $��0��6%   $
��Left=�65   $��3q�6P   $��6��6[   $��Center=�6h   �� 51      -
   5        $ phoneTextBox��51      $��1��6,   $
��Left=�6<   $��23��6W   $��3q�6c   $��6��6n   $��Center=�6�   $	��120��6�   ��6{   �� *Phone+$ TwoWay=�	 . 
 . 6�   �� 52      $��Speciality:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��7��6`   $��Center=�6m   �� 53      -   5        $ specialityTextBox��53      $��1��61   $
��Left=�6A   $��23��6\   $��3q�6h   $��7��6s   $��Center=�6�   $	��120��6�   ��6�   �� *
Speciality+$ TwoWay=�	 . 
 . 6�   �� 54      $��
User Name:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��8��6_   $��Center=�6l   �� 55      -   5        $ userNameTextBox��55      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��8��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
UserName+$ TwoWay=�	 . 
 . 6�   56      58      59      