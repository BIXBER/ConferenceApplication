   M S B A M L   `   `   `  ����P  LConferenceApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ConferenceApplicationConferenceApplication  5   	   &     ConferenceApplication.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ConferenceApplication     5   	     � Title$  Конференция��5   	   $	��600��6   $	��800��6*   $	��400��66   $	��500��6F   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $	��400 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��620 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 
ButtonBack��5      $��
Назад��6%   $
��Left=�65   $��
10 10 0 10q�6P   $
��60.9��6d   $��30��6�    � 5   
   -   5          �Name$ 	MainFrame��5        � NavigationUIVisibility$ Hidden=�6#     � Source$ Pages/EventListPage.xaml?�6C   $��1��6e   $<��6Главная страница авторизации��6u   $��1��6�   $	��400��6�   $��Center=�6�   $��Center=�6�   $	��620��6�   $��Disabled=�6  5      5      