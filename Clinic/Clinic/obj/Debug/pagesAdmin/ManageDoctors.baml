   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Clinic.pagesAdminClinic.pagesAdmin  5      > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null&clr-namespace:DAL;assembly=DALDAL 5      %    Clinic.pagesAdmin.ManageDoctors   5      a ]DevExpress.Xpf.Core.v17.2, Version=17.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Clinic.pagesAdmin     5      .DALclr-namespace:DAL;assembly=DAL     5      -   5          N� Title$  ManageDoctors��5
       � 	Resources 5         doctorViewSource  doctor_scheduleViewSource��%:   &	        &	      �� 5   
   6   �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   � -   5         �Name$ grid1��5      $
��Left=�6   $��	84,28,0,0q�69   $	��Top=�6L    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    .+�5"      �� -   5         ��Name$ lblDoctorId��5"      $	��Id:��6)   $��0��67   $
��Left=�6G   $��3q�6b   $��2��6m   $��Center=�6z   �� 5#      -   5        $ idLabel��5#      $��1��6<   $
��Left=�6L   $��3q�6g   $��2��6r   $��Center=�6   ��6%   �� *Id+6   �� 5$      $��First Name:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��1��6`   $��Center=�6m   �� 5%      -   5         ��Name$ firstNameTextBox��5%      $��1��60   $
��Left=�6@   $��23��6[   $��3q�6g   $��1��6r   $��Center=�6�   $	��120��6�   ��6   �� *	FirstName+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . 6�   �� 5&      $��
Last Name:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��3��6_   $��Center=�6l   �� 5'      -   5        $ lastNameTextBox��5'      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��3��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
LastName+$ TwoWay=�	 . 
 . 6�   �� 5(      $��Email:��6   $��0��6%   $
��Left=�65   $��3q�6P   $��0��6[   $��Center=�6h   �� 5)      -   5        $ 
emailLabel��5)      $��1��6B   $
��Left=�6R   $��3q�6m   $��0��6x   $��Center=�6�   ��6(   �� *Email+6�   �� 5*      $��Login Pass Word:��6   $��0��6/   $
��Left=�6?   $��3q�6Z   $��4��6e   $��Center=�6r   �� 5+      -   5        $ loginPassWordTextBox��5+      $��1��64   $
��Left=�6D   $��23��6_   $��3q�6k   $��4��6v   $��Center=�6�   $	��120��6  ��6�   �� *LoginPassWord+$ TwoWay=�	 . 
 . 6  �� 5,      $��Phone:��6   $��0��6%   $
��Left=�65   $��3q�6P   $��5��6[   $��Center=�6h   �� 5-      -	   5        $ phoneTextBox��5-      $��1��6,   $
��Left=�6<   $��23��6W   $��3q�6c   $��5��6n   $��Center=�6�   $	��120��6�   ��6{   �� *Phone+$ TwoWay=�	 . 
 . 6�   �� 5.      $��Speciality:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��6��6`   $��Center=�6m   �� 5/      -
   5        $ specialityTextBox��5/      $��1��61   $
��Left=�6A   $��23��6\   $��3q�6h   $��6��6s   $��Center=�6�   $	��120��6�   ��6�   �� *
Speciality+$ TwoWay=�	 . 
 . 6�   �� 50      $��
User Name:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��7��6_   $��Center=�6l   �� 51      -   5        $ userNameTextBox��51      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��7��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
UserName+$ TwoWay=�	 . 
 . 6�   52      �� 53   
   -   5         ��Name$ 
btPrevious��53      $��Previous��6%   $
��Left=�68   $��
360,28,0,0q�6S   $	��Top=�6g   $��75��6   6�   �� 54   
   -   5        $ btNext��54      $
��Next��6!   $
��Left=�60   $��
440,28,0,0q�6K   $	��Top=�6_   $��75��6w   6�   �� 55   
   -   5        $ btUpdate��55      $��Update��6#   $
��Left=�64   $��
460,90,0,0q�6O   $	��Top=�6c   $��75��6{   6�   �� 56   
   -   5        $ btDelete��56      $��Delete��6#   $
��Left=�64   $��
563,90,0,0q�6O   $	��Top=�6c   $��75��6{   6�   �� 57   
   -   5        $ btAdd��57      $	��Add��6!   $
��Left=�6/   $��
360,90,0,0q�6J   $	��Top=�6^   $��75��6v   6�   �� 58   
   -   5        $ 	btRefresh��58      $��refresh��6$   $
��Left=�66   $��360,174,0,0q�6Q   $	��Top=�6f   $��75��6~   6�   59      5:      