   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   J FNFG Launcher V2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:NFG_Launcher_V2NFG_Launcher_V2 5   	       NFG_Launcher_V2.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   /localclr-namespace:NFG_Launcher_V2     5   	     � Title$-  'OurSecrets Server Browser V. Alpha-1.02��5	   	   $	��720��69   $	��900��6F    � Icon$ /Images\Bite1.png��6R    � 
ResizeMode$ NoResize=�6k    � 	Resources 5       �� MergedDictionaries   Key  MetroTabItem �� BasedOn �� 
TargetType+   %MahApps.Metro.Controls.ControlsHelper �� Property �� Value	 �� Source�� 5   
    5      �� 5      �� 5      MenuItemHeader  # [ 63   " ��6[   .�5      ��  �@ HeaderFontSize$ 24Q�6S   6`   �� 5       � ��$ 	0,10,0,10q�64   5      5      �� 5      $	 /Resources/Icons.xaml?�6%   %    5      (   "MahApps.Metro.Controls.MetroWindow
   RightWindowCommands
 5      +   %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� $��settings��6   �� 5      -   5        $��btnHelp��5      .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��20��6    $��20��5       ��5!      ��  �� RelativeSource ��  �� AncestorType$ ButtonL� �� Path$ 
Foreground� J� OpacityMask 5"      !� 5#       j� Stretch$
 Fill=�6*     appbar_question !� Visual# [ 69   5%      �� 5&      $��4 0 0 0q�6    $��Center=�5'      $
��Help��5(      5)      5*      5+      .��5.      � ��5/   
   �� 50       �� ImageSource$ Images/background.jpg��6   $ UniformToFill=�6=   .+�52   
   �� -   5        $��tbProgressUpdate��52      
�������$��10,632,692,10q�6@   �� 53   
    �� TabStripPlacement$
 Left=�6   $��0��6.   $��Center=�6>   $
��0,10q�6[   $	��892��6i   .@�54      ��   MenuItemHeader#��[ 6   $��
10,0,-10,0q�6>   ��55      �� 56      .R�57      ]� ��. .+�58      �� $
��Left=�6(   $��20��6>   $��20��6I   ��6U   ��  �� " ��$ (TextElement.Foreground)� 59   "   !� 5:   &   $
 Fill=�62     appbar_chess_king# [ 6A   5<      �� 5=      $��10,0,0,0q�6%   $��Grandpas Secret��5@   %   ��5>   %   ��  �� " ��$ (TextElement.Foreground)���5?   %   ��  �� " ��$ (TextElement.FontSize)�5@   %   5A      5B      .��5D      � $��-4,0,4,0q�6   .+�5E      �� -   5         ��Name$ btnGrandpaDonate��5E      $��Grandpa's Donators��67   $
��Left=�6T   $��125,550,0,0q�6o   $	��Top=�6�   $	��161��6�   $��62��6�   6�   �� 5F      -   5         ��Name$ 
textBlock1��5F       $
��Left=�64   $��
10,454,0,0q�6O   $
��Wrap=�6c   $����DONORS Get: 2 Base Teleports, 2 Base Protections, 2 Waypoint's  Of  Their Very Own. One Can Be Shared With Friends & The Other Can Only Be Used By The Donor, They Also Get To Travel As Far As 20,000 Anywhere On The Map & Also Get 15 Gimmes. ��6w   $	��Top=�6x  $��80��6�  $��14(�6�  $��Georgia)�6�  �� 5G      -   5        $ btnPlayGrandpa��5G      $��	Play Now!��65   $
��Left=�6I   $��452,550,0,0q�6d   $	��Top=�6y   $	��152��6�   $��62��6�   �� 5H      -   5        $ btnVoteGrandpa��5H      $�� ��65   $
��Left=�6@   $��
154,10,0,0q�6[   $	��Top=�6o   $	��347��6�   $��51��6�   $��36(�6�   
���������5I      �� 5J      $( "Images/banner-35620-1483803446.gif��6)   5L      5N      5O      �� 5P      $��Albums��6   #��[ 6&   $��
10,0,-10,0q�6N   ��5Q      �� 5R      .R�5S      ]� ��. .+�5T      �� $
��Left=�6(   $��20��6>   $��20��6I   ��6U   ��  �� " ��$ (TextElement.Foreground)� 5U   "   !� 5V   &   $
 Fill=�62     appbar_chess_queen# [ 6A   5X      �� 5Y      $��10,0,0,0q�6%   $��Grandmas Secret��5\   %   ��5Z   %   ��  �� " ��$ (TextElement.Foreground)���5[   %   ��  �� " ��$ (TextElement.FontSize)�5\   %   5]      5^      .��5`      � $��-4,0,4,0q�6   .+�5a      �� -   5        $ btnGrandmaDonators��5a      $��Grandpa's Donators��69   $
��Left=�6V   $��125,550,0,0q�6q   $	��Top=�6�   $	��161��6�   $��62��6�   6�   �� 5b      -   5        $ 
textBlock2��5b       $
��Left=�64   $��
10,454,0,0q�6O   $
��Wrap=�6c   $����DONORS Get: 2 Base Teleports, 2 Base Protections, 2 Waypoint's  Of  Their Very Own. One Can Be Shared With Friends & The Other Can Only Be Used By The Donor, They Also Get To Travel As Far As 20,000 Anywhere On The Map & Also Get 15 Gimmes. ��6w   $	��Top=�6x  $��80��6�  $��14(�6�  $��Georgia)�6�  �� 5c      -	   5        $ btnPlayGrandma��5c      $��	Play Now!��65   $
��Left=�6I   $��452,550,0,0q�6d   $	��Top=�6y   $	��152��6�   $��62��6�   �� 5d      -
   5        $ btnVoteGrandma��5d      $�� ��65   $
��Left=�6@   $��
154,10,0,0q�6[   $	��Top=�6o   $	��347��6�   $��51��6�   $��36(�6�   
���������5e      �� 5f      $( "Images/banner-35620-1483803446.gif��6)   5h      5i      5j      �� 5k      -   5         ��Name$ tabInsurgency��5k      $��
Insurgency��6.   #��[ 6B   $��10,2,-10,-2q�6j   ��5l      �� 5m      .R�5n      ]� ��. .+�5o      �� $
��Left=�6(   $��20��6>   $��20��6I   ��6U   ��  �� " ��$ (TextElement.Foreground)� 5p   "   !� 5q   &   $
 Fill=�62     appbar_rocket# [ 6A   5s      �� 5t      $��10,0,0,0q�6%   $��Dirty Secrets��5w   %   ��5u   %   ��  �� " ��$ (TextElement.Foreground)���5v   %   ��  �� " ��$ (TextElement.FontSize)�5w   %   5x      5y      .��5|      � $��-4,0,4,0q�6   .+�5}      �� -   5        $ btnDirtyDonetors��5}      $��Grandpa's Donators��67   $
��Left=�6T   $��125,550,0,0q�6o   $	��Top=�6�   $	��161��6�   $��62��6�   6�   �� 5~      -   5        $ 
textBlock3��5~       $
��Left=�64   $��
10,454,0,0q�6O   $
��Wrap=�6c   $����DONORS Get: 2 Base Teleports, 2 Base Protections, 2 Waypoint's  Of  Their Very Own. One Can Be Shared With Friends & The Other Can Only Be Used By The Donor, They Also Get To Travel As Far As 20,000 Anywhere On The Map & Also Get 15 Gimmes. ��6w   $	��Top=�6x  $��80��6�  $��14(�6�  $��Georgia)�6�  �� 5      -   5        $ btnPlayDirty��5      $��	Play Now!��63   $
��Left=�6G   $��452,550,0,0q�6b   $	��Top=�6w   $	��152��6�   $��62��6�   �� 5�      -   5        $ btnVoteDirty��5�      $�� ��63   $
��Left=�6>   $��
154,10,0,0q�6Y   $	��Top=�6m   $	��347��6�   $��51��6�   $��36(�6�   
���������5�      �� 5�      $( "Images/banner-35620-1483803446.gif��6)   5�      5�      5�      5�      5�      5�      