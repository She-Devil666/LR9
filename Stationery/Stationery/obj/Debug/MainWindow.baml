   M S B A M L   `   `   `  ????E  AStationery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Stationery
Stationery  5   	       Stationery.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Stationery     5   	     ? Title$  
MainWindow??5   	   $	??500??6   $	??900??6)    ? WindowStartupLocation$ CenterScreen=?65   ??5	      ?? 5
   
    ?? ImageSource$ Resources/back_main.jpg??6   6=   .??5      ?  ? RowDefinitions 5   
   ?? 5      $	??150 ?6   6+   ?? 5      6    ? ColumnDefinitions 5   
   ?? 5      $??80 ?6   6,   ?? 5      6!   ?? 5      $??80 ?6   6,   .+?5   
   ?? $??0??6   $??1??6"    ?? Orientation$ 
Horizontal=?62   $??Center=?6K   .+?5      ?? $ 
Horizontal=?6   $??50??62   .+?5      ?? $??ZAKKA??6      
logo_style#??[  6)   $??Center=?6M    J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q?6+      	Direction$ 10Q?6;   	   Color$
	 Gray??6J   6Y   5      5      5      ?? 5   
   $??1??6   $??1??6"   $ Vertical=?62   $??Center=?6I   $??Center=?6f   .+?5       ?? $????Магазин канцтоваров ZAKKA всегда рад новым покупателям. Вы можете найти и купить по достпумной цене любые канцелярские товары на любой вкус :)??6   $	??400??5!      $	??120??6$   $
??Wrap=?61     
text_style#??[ 6E   
 ?? TextAlignment$
 Center=?6i   $??16(?6?   6?   ?? 5"      -   5         ??Name$ 	btn_start??5"      $??Начать??6@     	btn_style#??[ 6Q   $??Center=?6t   $	??200??6?   $??50??6?   6?   5#      5$      5%      