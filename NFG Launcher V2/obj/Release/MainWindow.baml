   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  J FNFG Launcher V2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:NFG_Launcher_V2NFG_Launcher_V2     NFG_Launcher_V2.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     /localclr-namespace:NFG_Launcher_V2       � Title$-  'OurSecrets Server Browser V. Alpha-1.02��$	��720��$	��900�� � Icon$ /Images\Bite1.png�� � 
ResizeMode$ NoResize=� � 	Resources  �� MergedDictionaries   Key  MetroTabItem �� BasedOn �� 
TargetType+   %MahApps.Metro.Controls.ControlsHelper �� Property �� Value	 �� Source��  �� �� MenuItemHeader  # [ " ��.���  �@ HeaderFontSize$ 24Q���  � ��$ 	0,10,0,10q��� $	 /Resources/Icons.xaml?�%    (   "MahApps.Metro.Controls.MetroWindow
   RightWindowCommands
 +   %MahApps.Metro.Controls.WindowCommands  .@��� $��settings���� -   $��btnHelp��.����  �� Orientation$ 
Horizontal=�.+��� $��20��$��20������  �� RelativeSource ��  �� AncestorType$ ButtonL� �� Path$ 
Foreground� J� OpacityMask !�  j� Stretch$
 Fill=�  appbar_question !� Visual# [ �� $��4 0 0 0q�$��Center=�$
��Help��.��� ����  �� ImageSource$ Images/background.jpg��$ UniformToFill=�.+��� -   $��tbProgressUpdate��
�������$��10,632,692,10q���  �� TabStripPlacement$
 Left=�$��0��$��Center=�$
��0,10q�$	��892��.@���   MenuItemHeader#��[ $��
10,0,-10,0q����� .R�]� ��. .+��� $
��Left=�$��20��$��20������  �� " ��$ (TextElement.Foreground)� !� $
 Fill=�  appbar_chess_king# [ �� $��10,0,0,0q�$��Grandpas Secret������  �� " ��$ (TextElement.Foreground)�����  �� " ��$ (TextElement.FontSize)�.��� $��-4,0,4,0q�.+��� -    ��Name$ btnGrandpaDonate��$��Grandpa's Donators��$
��Left=�$��125,550,0,0q�$	��Top=�$	��161��$��62���� -    ��Name$ 
textBlock1��$
��Left=�$��
10,454,0,0q�$
��Wrap=�$����DONORS Get: 2 Base Teleports, 2 Base Protections, 2 Waypoint's  Of  Their Very Own. One Can Be Shared With Friends & The Other Can Only Be Used By The Donor, They Also Get To Travel As Far As 20,000 Anywhere On The Map & Also Get 15 Gimmes. ��$	��Top=�$��80��$��14(�$��Georgia)��� -   $ btnPlayGrandpa��$��	Play Now!��$
��Left=�$��452,550,0,0q�$	��Top=�$	��152��$��62���� -   $ btnVoteGrandpa��$��	VOTE NOW!��$
��Left=�$��
154,10,0,0q�$	��Top=�$	��347��$��51��$��12(�
����������� $ Images/Capture.PNG���� $��Albums��#��[ $��
10,0,-10,0q����� .R�]� ��. .+��� $
��Left=�$��20��$��20������  �� " ��$ (TextElement.Foreground)� !� $
 Fill=�  appbar_chess_queen# [ �� $��10,0,0,0q�$��Grandmas Secret������  �� " ��$ (TextElement.Foreground)�����  �� " ��$ (TextElement.FontSize)�.��� $��-4,0,4,0q�.+��� -   $ btnGrandmaDonators��$��Grandpa's Donators��$
��Left=�$��125,550,0,0q�$	��Top=�$	��161��$��62���� -   $ 
textBlock2��$
��Left=�$��
10,454,0,0q�$
��Wrap=�$����DONORS Get: 2 Base Teleports, 2 Base Protections, 2 Waypoint's  Of  Their Very Own. One Can Be Shared With Friends & The Other Can Only Be Used By The Donor, They Also Get To Travel As Far As 20,000 Anywhere On The Map & Also Get 15 Gimmes. ��$	��Top=�$��80��$��14(�$��Georgia)��� -	   $ btnPlayGrandma��$��	Play Now!��$
��Left=�$��452,550,0,0q�$	��Top=�$	��152��$��62���� -
   $ btnVoteGrandma��$��	VOTE NOW!��$
��Left=�$��
154,10,0,0q�$	��Top=�$	��347��$��51��$��12(�
����������� $ Images/Capture.PNG���� -    ��Name$ tabInsurgency��$��
Insurgency��#��[ $��10,2,-10,-2q����� .R�]� ��. .+��� $
��Left=�$��20��$��20������  �� " ��$ (TextElement.Foreground)� !� $
 Fill=�  appbar_rocket# [ �� $��10,0,0,0q�$��Dirty Secrets������  �� " ��$ (TextElement.Foreground)�����  �� " ��$ (TextElement.FontSize)�.��� $��-4,0,4,0q�.+��� -   $ btnDirtyDonetors��$��Grandpa's Donators��$
��Left=�$��125,550,0,0q�$	��Top=�$	��161��$��62���� -   $ 
textBlock3��$
��Left=�$��
10,454,0,0q�$
��Wrap=�$����DONORS Get: 2 Base Teleports, 2 Base Protections, 2 Waypoint's  Of  Their Very Own. One Can Be Shared With Friends & The Other Can Only Be Used By The Donor, They Also Get To Travel As Far As 20,000 Anywhere On The Map & Also Get 15 Gimmes. ��$	��Top=�$��80��$��14(�$��Georgia)��� -   $ btnPlayDirty��$��	Play Now!��$
��Left=�$��452,550,0,0q�$	��Top=�$	��152��$��62���� -   $ btnVoteDirty��$��	VOTE NOW!��$
��Left=�$��
154,10,0,0q�$	��Top=�$	��347��$��51��$��12(�
����������� $ Images/Capture.PNG��