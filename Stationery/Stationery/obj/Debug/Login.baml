   M S B A M L   `   `   `  ????E  AStationery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Stationery
Stationery  5   	       Stationery.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Stationery     5   	     ? Title$  Вход??5   	   $	??600??6   $	??400??6#    ? WindowStartupLocation$ CenterScreen=?6/   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $	??100 ?6   6+   ?? 5      $??70 ?6   6*   ?? 5      6   .+?5   
   ?? $??0??6   $??1??6"    ?? Orientation$ 
Horizontal=?62   $??Center=?6K   .+?5      ?? $ 
Horizontal=?6   $??50??62   .+?5      ?? $??ZAKKA??6      
logo_style#??[  6)   $??Center=?6M   6j   5      5      ?? 5   
   $??1??6   $ Vertical=?6"   $??Center=?69   $??Bottom=?6V   .+?5      ?? $??Авторизация??6     headline_style#??[ 6+   6U   5      ?? 5   
   $??2??6   $ Vertical=?6"   $??Center=?69   $??Center=?6V   .+?5      ??   
text_style#??[ 6   $??
Логин??6<   $??0 0 0 10q?6I   6]   ?? 5      -   5         ??Name$ 
tbox_login??5      $	??250??6*   $??25??66   $??0 0 0 20q?6B     text_field_style#??[ 6T   6?   ?? 5      #??[ 6   $??Пароль??6<   $??0 0 0 10q?6J   6^   G? 5      -   5         G?Name$ 	tbox_pass??5      $	??250??6-   $??25??69   $??0 0 0 50q?6E     pass_field_style#??[ 6W   6?   ?? 5      -   5         ??Name$ 	btn_login??5        	btn_style#??[ 6(   $	??150??6K   $??50??6W   $??
Войти??6c   $??0 0 0 10q?6?   6?   ?? 5      -   5        $ 
btn_signin??5        nav_link_style#??[ 6B   $??30??6j   $??Регистрация??6v   $	??100??6?   6?   5      5      5       