   M S B A M L   `   `   `  ????E  AStationery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Stationery
Stationery  5   	       Stationery.Profile   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Stationery     5   	     ? Title$!  Личный профиль??5   	   $	??400??6    $	??700??6-    ? WindowStartupLocation$ CenterScreen=?69   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $	??100 ?6   6+   ?? 5      6    ? ColumnDefinitions 5   
   ?? 5      $??80 ?6   6,   ?? 5      6!   ?? 5      $??80 ?6   6,   .+?5   
   ?? $??0??6   $??1??6"    ?? Orientation$ 
Horizontal=?62   $??Center=?6K   $
??Left=?6f   .+?5      ?? $ 
Horizontal=?6   $??40??62   .+?5      ?? $??ZAKKA??6      
logo_style#??[  6)   $??Center=?6M   6j   ?? 5      -   5         ??Name$ btn_shop??5      $??Магазин??6B     nav_link_style#??[ 6T   $??40 0 0 0q?6|   6?   ?? 5      -   5        $ 
btn_basket??5      $??Корзина??6F   #??[ 6X   $??20 0 0 0q?6?   6?   ?? 5      -   5        $ btn_profile??5      $??Профиль??6.   #??[ 6@   ???#b1f0eb$??20 0 0 0q?6}   6?   5      5      ?? 5   
   $??1??6   $??1??6"   $ Vertical=?62   .+?5      ?? $ 
Horizontal=?6   $
??Left=?62   $??Center=?6M   $??	0 30 0 30q?6h   .+?5      ??   headline_style#??[ 62   $??20(?6Z   ??6   ?? *name+6j   ?? 5      $?? ??6   6'   ?? 5      #??[ 65   $??20(?6]   ??6   ?? *	surname+6m   5       ?? 5!      $ 
Horizontal=?6   $
??Left=?62   $??Center=?6M   $??0 0 0 10q?6h   .+?5"      ?? $??Эл. почта: ??6     
text_style#??[ 6/   6U   ?? 5#      #??[ 63   ??6   ?? *email+6Y   5$      ?? 5%      $ 
Horizontal=?6   $
??Left=?62   $??Center=?6M   $??0 0 0 40q?6h   .+?5&      ?? $#??Номер телефона: ??6   #??[ 64   6Z   ?? 5'      #??[ 63   ??6   ?? *phone+6Y   5(      ?? 5)      $ Vertical=?6   $??Center=?60   $
??Left=?6K   .+?5*      ?? -   5        $ btn_exit??5*        lview_btn_style#??[ 6+   $&?? Выйти из акканута??6T   $	??160??6p   $??35??6|   $??13(?6?   $??Medium"?6?   6?   5+      5,      5-      5.      