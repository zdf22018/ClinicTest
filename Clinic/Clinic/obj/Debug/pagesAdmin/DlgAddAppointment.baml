   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Clinic.pagesAdminClinic.pagesAdmin  5   	   > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null&clr-namespace:DAL;assembly=DALDAL 5   	   )    #Clinic.pagesAdmin.DlgAddAppointment   5   	   a ]DevExpress.Xpf.Core.v17.2, Version=17.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Clinic.pagesAdmin     5   	   .DALclr-namespace:DAL;assembly=DAL     5   	   -   5          � Title$  DlgAddAppointment��5	   	   $	��450��6#   $	��800��60    � 	Resources 5
       %  !display_available_slotsViewSource  patientViewSource��%:   &	        &	      �� 5   
   6   �� 5   
   6   5      .��5      �  � DataContext# [  6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$% display_available_slotsDataGrid��5         RowDetailsVisibilityMode$ VisibleWhenSelected=�6<   $��10,75,377,174q�6k      EnableRowVirtualization .    AutoGenerateColumns .  ��6�   ��    Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        doctorColumn��,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 5   ?   	   Header$	 Doctor��6K   
   CellTemplate
 5      �� 5      .R�5      �� ��6$   �� *Doctor+5      5        5      -   5        startColumn��$	 120 5   >   $	 Start��6J   
 5      �� 5      .R�5      �� ��6$   �� *Start+5      5         5!      -   5        	endColumn��$	 120 5!   <   $		 End��6H   
 5"      �� 5#      .R�5$      �� ��6$   �� *End+5%      5'        5(      -   5        timeSoltIdColumn��$ 80 5(   C   $	 Time Solt Id��6N   
 5)      �� 5*      .R�5+      �� ��6$   �� *
TimeSoltId+5,      5.      50      �� 51   
   $��Doctor��6   $
��Left=�6!   $��	57,17,0,0q�6<   $	��Top=�6O   $��62��6g   �� 52   
   -   5         ��Name$ tbName��52      $
��Left=�6#   $��23��6>   $��
104,18,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   �� 53   
   $
��From��6   $
��Left=�6   $��
264,17,0,0q�6:   $	��Top=�6N   (  "System.Windows.Controls.DatePicker  54   
   -   5          Name$ dpFrom��54      $
��Left=�6%   $��
297,18,0,0q�6@   $	��Top=�6T   �� 55   
   $��To��6   $
��Left=�6   $��
432,20,0,0q�68   $	��Top=�6L   $��27��6d     56   
   -	   5        $
 dpTo��56      $
��Left=�6#   $��
474,18,0,0q�6>   $	��Top=�6R   $	��129��6j   �� 57   
   -
   5         ��Name$ btTakeAppointment��57      $��Make New Appointment��6-   $
��Left=�6L   $��432,223,0,0q�6g   $	��Top=�6|   $	��180��6�   6�   �� 58   
   -   5         ��Name$ patientListView��58      $��10,306,518,10q�6n    �� SelectionMode$ Single=�6�   ��6,   ��  �� Source# [ ��59      �� 5:      .�5;      ��  �� Property � �� �� Value$ Stretch=�6K   �� 5<       � ��$ Stretch=�6I   5=       �� View 5?      �� 5@      .P�5A      �� -   5        fullNameColumn��$��	Full Name��5A   =    �� Width$	 140��6P    �� CellTemplate 5B      �� 5C      .R�5D   "   �� $��
6,-1,-6,-1q�6E   ��6(   �� *
FullName+6E   5E      5G      �� 5H      -   5        idColumn��$��Id��5H   7   $ 80��6C    5I      �� 5J      .R�5K   "   �� $��-6,-1q�6?   ��6(   �� *Id+6?   5L      5N      5O      5Q      �� 5R   
   $��Choose Patient��6   $
��Left=�6)   $��
10,259,0,0q�6D   $	��Top=�6X   �� 5S   
   $��choose spot ��6   $
��Left=�6'   $��	10,44,0,0q�6B   $	��Top=�6U   $��99��6m   �� 5T   
   $#��You can type for quick filter��6   $
��Left=�68   $��104,260,0,0q�6S   $	��Top=�6h   $	��155��6�   �� 5U   
   -   5        $ tbPatientName��5U      $
��Left=�6)   $��23��6D   $��259,259,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   6�   �� 5V   
   -   5        $ btSearch��5V      $��Search��6$   $
��Left=�65   $��
474,66,0,0q�6P   $	��Top=�6d   $	��129��6|   6�   5X      5Y      