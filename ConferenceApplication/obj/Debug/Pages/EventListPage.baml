   M S B A M L   `   `   `  ����P  LConferenceApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ConferenceApplication.PagesConferenceApplication.Pages  5      /    )ConferenceApplication.Pages.EventListPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ConferenceApplication.Pages     5        N� 
Background
  ����� N� Title$) #Список мероприятий��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5       � RowDefinitions 5   
   �� 5      $
��377* �6   �� 5      $	��73* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridEvents��5      $��0��6(   $��2��65      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Номер��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 6Q   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 64   �� *
event_id+6_     5      $ Название��6%   $		 500 6Q   
 67   �� *title+6_     5      $ Дата��6%   $		 150 6q   
 63   �� *
start_date+ �� StringFormat$ {0:yyyy-MM-dd}��6     5      $ Дни��6%   $		 100 6T   
 62   �� *duration_days+6b     5      $ 
Город��6%   $		 150 6U   
 64   �� *cities.title+6c   5      �� 5   
   -   5         ��Name$ loginButton��5      $��
Войти��6&   $��Center=�66   $��1��6S   $��Center=�6`   $	��150��6{   $��30��6�   $��16(�6�   $��0��6�   $
��Bold"�6�   �� 5   
   -   5        $ registerButton��5      $*��$Зарегистрироваться��6)   $��Center=�6F   $��1��6c   $��Center=�6p   $	��150��6�   $��30��6�   $��14(�6�   $
��Bold"�6�   $��1��6�   5       5!      