   M S B A M L   `   `   `  ����  HeroRandomaizer     HeroRandomaizer.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Hero Manager��5   	   $	��500��6   $	��800��6+   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��0,0,0,10q�6;   .+�5      �� $��
All Heroes��6   $��24(�5      $
��Bold"�5      ���#2c3e50$��Center=�5      �� 5      -   5         ��Name$ CreateHeroButton��5      $��Create New Hero��5      $	��150��5      $��30��5      $��14(�5      $��20,0,0,0q�5      5      5      �� 5   
   -   5        $��HeroesListBox��5      $��1��6'   $��Stretch=�64   ��5      �� 5      .R�5      �� $��5q�6!   .+�5      �� $��16(�6:   $
��Bold"�6H   ���#2c3e50��6$   �� *Name+6Z   �� 5      $��Clan: ��6$   $��14(�62   ���#7f8c8d
�5       �� 5!   "   �6&   �� *	Clan.Name+5#      �� 5$      $��Power Attribute: ��6$   $��14(�6=   ���#7f8c8d
�5%      �� 5&   "   �6&   �� *PowerAttribute.Attribute+5(      �� 5)      $ 
Horizontal=�6%   $��0,10,0,0q�6>   .+�5*      �� -   5        $
��Edit��5*   %   $��80��64   $��0,0,10,0q�6?   
 � Tag 5,   %   �� *HeroId+�� 5-      -   5        $��Delete��5-   %   $��80��66    5/   %   �� *HeroId+50      51      52      54      55      56      