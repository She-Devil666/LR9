   M S B A M L   `   `   `  ????E  AStationery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Stationery
Stationery  5   	       Stationery.For_admin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Stationery     5   	   -   5          ? Title$-  'Панель адмнистратора??5   
   $	??800??6'   $
??1000??64    ? WindowStartupLocation$ CenterScreen=?6A   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $	??100 ?6   6+   ?? 5      $??70 ?6   6*   ?? 5      6   ?? 5      $	??150 ?6   6+    ? ColumnDefinitions 5   
   ?? 5      $	??100 ?6   6-   ?? 5      6!   ?? 5      $	??100 ?6   6-   .+?5   
   ?? $??0??6   $??1??6"    ?? Orientation$ 
Horizontal=?62   $??Center=?6K   .+?5      ?? $ 
Horizontal=?6   $??50??62   .+?5      ?? $??ZAKKA??6      
logo_style#??[  6)   $??Center=?6M   6j   5      5      ?? 5   
   $??1??6   $??3??6"   $ Vertical=?66   $??Center=?6M   $??Center=?6j   .+?5      ?? $??Админ-панель??6     headline_style#??[ 6,   $??Light"?6T   6i   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgrid_goods??5         AutoGenerateColumns .     
IsReadOnly . $??1??6V   $??2??6f      SelectionMode$ Single=?6s   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Наименование??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 250 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   ?? *name+6b     5       $
 Кол-во??6%   $ 70 6O    65   ?? *count+6\     5!      $
 Артикул??6%   $	 100 6N    66   ?? *SKU+6\     5"      $
 Цена??6%   $	 100 6c    63   ?? *price+ ?? StringFormat$ {0} Р??6q   4  .System.Windows.Controls.DataGridTemplateColumn  5#      $	 110 6)      CellTemplate 5$      ?? 5%      .R?5&      ??  ??Name$ btn_edit??6%   -   5        $??Изменить??5&   N   ???#b1f0eb6x   5'      5)      5+      ?? 5,   
   $??3??6   $??1??6"   $ 
Horizontal=?62   $
??Left=?6K   $	??Top=?6f   .+?5-      ?? -   5        $ btn_add??5-      $!??Добавить товар??6&     	btn_style#??[ 6U   $	??200??6x   $??50??6?   $??0 30 0 0q?6?   6?   ?? 5.      -   5        $ 
remove_add??5.      $!??Удалить товары??6)   #??[ 6[   $	??200??6~   $??50??6?   $??	20 30 0 0q?6?   6?   5/      ?? 50   
   $??0??6   $??2??6"   $ Vertical=?62   $??Center=?6I   $??Center=?6f   .+?51      ?? -   5        $ btn_exit??51      $??
Выход??6'     nav_link_style#??[ 6N   6x   52      53      54      