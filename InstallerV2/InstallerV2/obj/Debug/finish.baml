   M S B A M L   `   `   `  ����F  BInstallerV2, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:InstallerV2InstallerV2  5          InstallerV2.finish   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:InstallerV2     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  finish��5      $	��646��5	      $	��433��5
       � 	Resources 5         IconButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value	 �� ImageSource  RoundCorner
 �Name ��Name �� CornerRadius �� 
TargetName��%I  &	        &	 y    �� 5   
   " ��6(   .�5      ��  � ��
 ���� 6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      � #��z��6   .+�5      �� 5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  � �� 5   &   �� 5   *   $)	 #/Resources/icons8_multiply_32px.png��65   5   #   5      5!      5#      5$      �� 5%   
   " ��6$   .�5&      ��  � ��$ Center=�6;   �� 5'       � ��$ Center=�69   �� 5(       � ��$ 1q�6(   �� 5)       � �� 5*      �� 5+      " ��6&   .R�5,      � $

 grid��6   .+�5-      �� $ border��5.   !   ���	#FFEFEFEF���	#FFBBBBBB$��1q�51   !   $ 8��52   !   ._�53   "   �� $��Center=�54   %   $��Center=�55   %   $��Normal"�56   %   57      59       5:      P� 5;       �@J�IsMouseOver . . �5<   "   �� $ border��6)    � �� �	#FF8E8D8D6T   5=      P� 5>       � {� .  . �5?   "   �� $
 grid��6)    �@J�Opacity$
 0.25Q�6N   5@      5C      5E      5F      5G      .��5H      � -   5        $	��646��5I   	   $	��433��5J   	   
�������.+�5M   
   �� -   5         ��Name$ 
textBlock1��5N      $	��626��5O      $	��180��5P      $��	0,123,0,0q�5Q      $��Center=�5R      $	��Top=�5S      $��Arial)�5T      $��40(�5U      
���   � J� RenderTransformOrigin$ 0.5,0.5&�5W      $��
Thank you!��5X       �� TextAlignment$ Center=�5Y      $
��Wrap=�5Z      z�5[      V� 5\      .~�5]      �� �� 5^      �� 5_      T� 5`      5a      5c      �� 5d   
   -   5        $ textBlock_did��5e      $	��385��5f      $��22��5g      $��	0,400,0,0q�5h      $��Center=�5i      $	��Top=�5j      $��Arial)�5k      $��15(�5l      
���   �$ 0.5,0.5&�5n      $>��8This installer is powered by Da4ndo's Easy Installer V2.��5o      $ Center=�5p      $
��Wrap=�5q      z�5r      V� 5s      .~�5t      �� �� 5u      �� 5v      T� 5w      5x      5z      �� 5{   
   -   5         ��Name$ button_exit��5|      $��73��5}      $��30��5~      $��563,393,0,0q�5      $
��Left=�5�      $	��Top=�5�      ���	#FF113C1E$
��Exit��5�      $��Arial)�5�      $��15(�5�      #���  5�      5�      5�      