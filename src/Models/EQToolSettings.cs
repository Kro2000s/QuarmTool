﻿using EQTool.Services;
using EQToolShared.ExtendedClasses;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows;

namespace EQTool.Models
{
	public class WindowState
	{
		public Rect? WindowRect { get; set; }
		public System.Windows.WindowState State { get; set; }
		public bool Closed { get; set; }
		public bool AlwaysOnTop { get; set; }

		private double _Opacity = 1.0;
		public double? Opacity
		{
			get
			{
				return _Opacity;
			}
			set
			{
				_Opacity = value ?? 1.0;
			}
		}
	}

	public class EQToolSettings : INotifyPropertyChanged
	{
		public string DefaultEqDirectory { get; set; }
		public string EqLogDirectory { get; set; }
		public string SelectedVoice { get; set; }
		private int _FontSize = 12;
		public int? FontSize
		{
			get
			{
				return _FontSize;
			}
			set
			{
				_FontSize = value ?? 12;
				_FontSize = _FontSize < 12 ? 12 : _FontSize;
			}
		}

		private int? _OverlayFontSize = 24;
		public int? OverlayFontSize
		{
			get
			{
				return _OverlayFontSize;
			}
			set
			{
				_OverlayFontSize = value ?? 24;
				_OverlayFontSize = _OverlayFontSize < 12 ? 12 : _OverlayFontSize;
			}
		}

		private System.Windows.Media.Color _EnrageOverlayColor = System.Windows.Media.Color.FromRgb(255, 255, 0); //Red
		private System.Windows.Media.Color _LevFadingOverlayColor = System.Windows.Media.Color.FromRgb(255, 255, 0); //Red
		private System.Windows.Media.Color _InvisFadingOverlayColor = System.Windows.Media.Color.FromRgb(255, 255, 0); //Red
		private System.Windows.Media.Color _FTEOverlayColor = System.Windows.Media.Color.FromRgb(255, 255, 0); //Red
		private System.Windows.Media.Color _CharmBreakOverlayColor = System.Windows.Media.Color.FromRgb(255, 255, 0); //Red
		private System.Windows.Media.Color _FailedFeignOverlayColor = System.Windows.Media.Color.FromRgb(255, 255, 0); //Red
		private System.Windows.Media.Color _GroupInviteOverlayColor = System.Windows.Media.Color.FromRgb(255, 255, 0); //Red
		private System.Windows.Media.Color _DragonRoarOverlayColor = System.Windows.Media.Color.FromRgb(255, 255, 0); //Red
		private System.Windows.Media.Color _RootWarningOverlayColor = System.Windows.Media.Color.FromRgb(255, 255, 0); //Red
		private System.Windows.Media.Color _ResistWarningOverlayColor = System.Windows.Media.Color.FromRgb(255, 255, 0); //Red


		public System.Windows.Media.Color ResistWarningOverlayColor
		{ 
			get => _ResistWarningOverlayColor; 
			set => _ResistWarningOverlayColor = value; 
		}
		public System.Windows.Media.Color RootWarningOverlayColor
		{ 
			get => _RootWarningOverlayColor; 
			set => _RootWarningOverlayColor = value; 
		}
		public System.Windows.Media.Color DragonRoarOverlayColor 
		{ 
			get => _DragonRoarOverlayColor; 
			set => _DragonRoarOverlayColor = value; 
		}
		public System.Windows.Media.Color GroupInviteOverlayColor
		{ 
			get => _GroupInviteOverlayColor; 
			set => _GroupInviteOverlayColor = value; 
		}
		public System.Windows.Media.Color FailedFeignOverlayColor
		{ 
			get => _FailedFeignOverlayColor; 
			set => _FailedFeignOverlayColor = value; 
		}
		public System.Windows.Media.Color CharmBreakOverlayColor
		{ 
			get => _CharmBreakOverlayColor; 
			set => _CharmBreakOverlayColor = value; 
		}
		public System.Windows.Media.Color FTEOverlayColor
		{ 
			get => _FTEOverlayColor; 
			set => _FTEOverlayColor = value; 
		}
		public System.Windows.Media.Color InvisFadingOverlayColor
		{ 
			get => _InvisFadingOverlayColor; 
			set => _InvisFadingOverlayColor = value; 
		}
		public System.Windows.Media.Color LevFadingOverlayColor
		{ 
			get => _LevFadingOverlayColor; 
			set => _LevFadingOverlayColor = value; 
		}
		public System.Windows.Media.Color EnrageOverlayColor
		{ 
			get => _EnrageOverlayColor; 
			set => _EnrageOverlayColor = value; 
		}



		private WindowState _OverlayWindowState;
		public WindowState OverlayWindowState
		{
			get
			{
				if (_OverlayWindowState == null)
				{
					_OverlayWindowState = new WindowState();
				}
				return _OverlayWindowState;
			}
			set => _OverlayWindowState = value ?? new WindowState();
		}

		private WindowState _SpellWindowState;
		public WindowState SpellWindowState
		{
			get
			{
				if (_SpellWindowState == null)
				{
					_SpellWindowState = new WindowState();
				}
				return _SpellWindowState;
			}
			set => _SpellWindowState = value ?? new WindowState();
		}

		private WindowState _TimerWindowState;
		public WindowState TimerWindowState
		{
			get
			{
				if (_TimerWindowState == null)
				{
					_TimerWindowState = new WindowState();
				}
				return _TimerWindowState;
			}
			set => _TimerWindowState = value ?? new WindowState();
		}


		private WindowState _ComboTimerWindowState;
		public WindowState ComboTimerWindowState
		{
			get
			{
				if (_ComboTimerWindowState == null)
				{
					_ComboTimerWindowState = new WindowState();
				}
				return _ComboTimerWindowState;
			}
			set => _ComboTimerWindowState = value ?? new WindowState();
		}

		private WindowState _DpsWindowState;
		public WindowState DpsWindowState
		{
			get
			{
				if (_DpsWindowState == null)
				{
					_DpsWindowState = new WindowState();
				}
				return _DpsWindowState;
			}
			set => _DpsWindowState = value ?? new WindowState();
		}

		private WindowState _MapWindowState;
		public WindowState MapWindowState
		{
			get
			{
				if (_MapWindowState == null)
				{
					_MapWindowState = new WindowState();
				}
				return _MapWindowState;
			}
			set => _MapWindowState = value ?? new WindowState();
		}

		private WindowState _MobWindowState;
		public WindowState MobWindowState
		{
			get
			{
				if (_MobWindowState == null)
				{
					_MobWindowState = new WindowState();
				}
				return _MobWindowState;
			}
			set => _MobWindowState = value ?? new WindowState();
		}

		private WindowState _SettingsWindowState;
		public WindowState SettingsWindowState
		{
			get
			{
				if (_SettingsWindowState == null)
				{
					_SettingsWindowState = new WindowState();
				}
				return _SettingsWindowState;
			}
			set => _SettingsWindowState = value ?? new WindowState();
		}

		public List<PlayerInfo> Players { get; set; } = new List<PlayerInfo>();

		public bool BestGuessSpells { get; set; }
		public bool YouOnlySpells { get; set; }
		public bool ShowRandomRolls { get; set; }

		public bool ComboShowRandomRolls { get; set; }
		public bool ComboShowSpells { get; set; }
		public bool ComboShowTimers { get; set; }

		private ObservableCollectionRange<CustomOverlay> _customOverlays;
		[JsonIgnore]
		public ObservableCollectionRange<CustomOverlay> CustomOverlays
		{
			get
			{
				if (_customOverlays == null || _customOverlays.Count == 0)
				{
					_customOverlays = new ObservableCollectionRange<CustomOverlay>();
					var tmp = CustomOverlayService.LoadCustomOverlayMessages();
					if(tmp != null)
					{
						_customOverlays.AddRange(tmp);
					}
				}
				return _customOverlays;
			}
			set
			{
				_customOverlays = value;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}
}
