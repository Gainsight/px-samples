//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace PXKit {
	[Register("PXUser", true)]
	public unsafe partial class PXUser : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("PXUser");
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected PXUser (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal PXUser (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithUserId:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public PXUser (string userId)
			: base (NSObjectFlag.Empty)
		{
			if (userId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var nsuserId = CFString.CreateNative (userId);
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithUserId:"), nsuserId), "initWithUserId:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("initWithUserId:"), nsuserId), "initWithUserId:");
			}
			CFString.ReleaseNative (nsuserId);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? AccountId {
			[Export ("accountId")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accountId")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accountId")))!;
				}
			}
			[Export ("setAccountId:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccountId:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setAccountId:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? City {
			[Export ("city")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("city")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("city")))!;
				}
			}
			[Export ("setCity:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCity:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setCity:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Continent {
			[Export ("continent")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("continent")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("continent")))!;
				}
			}
			[Export ("setContinent:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setContinent:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setContinent:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? CountryCode {
			[Export ("countryCode")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("countryCode")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("countryCode")))!;
				}
			}
			[Export ("setCountryCode:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCountryCode:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setCountryCode:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? CountryName {
			[Export ("countryName")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("countryName")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("countryName")))!;
				}
			}
			[Export ("setCountryName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCountryName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setCountryName:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? CustomAttributes {
			[Export ("customAttributes", ArgumentSemantic.Copy)]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("customAttributes")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customAttributes")))!;
				}
				return ret!;
			}
			[Export ("setCustomAttributes:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setCustomAttributes:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setCustomAttributes:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Email {
			[Export ("email")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("email")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("email")))!;
				}
			}
			[Export ("setEmail:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setEmail:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setEmail:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? FirstName {
			[Export ("firstName")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("firstName")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("firstName")))!;
				}
			}
			[Export ("setFirstName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setFirstName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setFirstName:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_FirstVisitDate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? FirstVisitDate {
			[Export ("firstVisitDate", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("firstVisitDate")))!;
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("firstVisitDate")))!;
				}
				MarkDirty ();
				__mt_FirstVisitDate_var = ret;
				return ret!;
			}
			[Export ("setFirstVisitDate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setFirstVisitDate:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setFirstVisitDate:"), value__handle__);
				}
				MarkDirty ();
				__mt_FirstVisitDate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Gender {
			[Export ("gender")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("gender")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("gender")))!;
				}
			}
			[Export ("setGender:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setGender:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setGender:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Ide {
			[Export ("ide")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("ide")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ide")))!;
				}
			}
			[Export ("setIde:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setIde:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setIde:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? LastName {
			[Export ("lastName")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("lastName")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lastName")))!;
				}
			}
			[Export ("setLastName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLastName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setLastName:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? Latitude {
			[Export ("latitude", ArgumentSemantic.Retain)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("latitude")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("latitude")))!;
				}
				return ret!;
			}
			[Export ("setLatitude:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLatitude:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setLatitude:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? Longitude {
			[Export ("longitude", ArgumentSemantic.Retain)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("longitude")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("longitude")))!;
				}
				return ret!;
			}
			[Export ("setLongitude:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLongitude:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setLongitude:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Organization {
			[Export ("organization")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("organization")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("organization")))!;
				}
			}
			[Export ("setOrganization:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setOrganization:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setOrganization:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? OrganizationDuns {
			[Export ("organizationDuns", ArgumentSemantic.Retain)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("organizationDuns")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("organizationDuns")))!;
				}
				return ret!;
			}
			[Export ("setOrganizationDuns:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setOrganizationDuns:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setOrganizationDuns:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? OrganizationEmployees {
			[Export ("organizationEmployees")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("organizationEmployees")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("organizationEmployees")))!;
				}
			}
			[Export ("setOrganizationEmployees:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setOrganizationEmployees:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setOrganizationEmployees:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? OrganizationIndustry {
			[Export ("organizationIndustry")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("organizationIndustry")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("organizationIndustry")))!;
				}
			}
			[Export ("setOrganizationIndustry:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setOrganizationIndustry:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setOrganizationIndustry:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? OrganizationRevenue {
			[Export ("organizationRevenue")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("organizationRevenue")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("organizationRevenue")))!;
				}
			}
			[Export ("setOrganizationRevenue:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setOrganizationRevenue:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setOrganizationRevenue:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? OrganizationSicCode {
			[Export ("organizationSicCode")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("organizationSicCode")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("organizationSicCode")))!;
				}
			}
			[Export ("setOrganizationSicCode:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setOrganizationSicCode:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setOrganizationSicCode:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Phone {
			[Export ("phone")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("phone")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("phone")))!;
				}
			}
			[Export ("setPhone:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPhone:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setPhone:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? PostalCode {
			[Export ("postalCode")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("postalCode")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("postalCode")))!;
				}
			}
			[Export ("setPostalCode:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setPostalCode:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setPostalCode:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? RegionName {
			[Export ("regionName")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("regionName")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("regionName")))!;
				}
			}
			[Export ("setRegionName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRegionName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setRegionName:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Role {
			[Export ("role")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("role")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("role")))!;
				}
			}
			[Export ("setRole:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRole:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setRole:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? Score {
			[Export ("score", ArgumentSemantic.Retain)]
			get {
				NSNumber? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("score")))!;
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("score")))!;
				}
				return ret!;
			}
			[Export ("setScore:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setScore:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setScore:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SfdcContactId {
			[Export ("sfdcContactId")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("sfdcContactId")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sfdcContactId")))!;
				}
			}
			[Export ("setSfdcContactId:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSfdcContactId:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSfdcContactId:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_SignUpDate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? SignUpDate {
			[Export ("signUpDate", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("signUpDate")))!;
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("signUpDate")))!;
				}
				MarkDirty ();
				__mt_SignUpDate_var = ret;
				return ret!;
			}
			[Export ("setSignUpDate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSignUpDate:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSignUpDate:"), value__handle__);
				}
				MarkDirty ();
				__mt_SignUpDate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? StateCode {
			[Export ("stateCode")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("stateCode")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stateCode")))!;
				}
			}
			[Export ("setStateCode:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setStateCode:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setStateCode:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? StateName {
			[Export ("stateName")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("stateName")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stateName")))!;
				}
			}
			[Export ("setStateName:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setStateName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setStateName:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Street {
			[Export ("street")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("street")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("street")))!;
				}
			}
			[Export ("setStreet:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setStreet:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setStreet:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SubscriptionId {
			[Export ("subscriptionId")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("subscriptionId")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subscriptionId")))!;
				}
			}
			[Export ("setSubscriptionId:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setSubscriptionId:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setSubscriptionId:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? TimeZone {
			[Export ("timeZone")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("timeZone")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("timeZone")))!;
				}
			}
			[Export ("setTimeZone:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTimeZone:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setTimeZone:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Title {
			[Export ("title")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("title")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("title")))!;
				}
			}
			[Export ("setTitle:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTitle:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setTitle:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? UserHash {
			[Export ("userHash")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("userHash")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.NativeHandle_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userHash")))!;
				}
			}
			[Export ("setUserHash:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setUserHash:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_NativeHandle (this.SuperHandle, Selector.GetHandle ("setUserHash:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_FirstVisitDate_var = null;
				__mt_SignUpDate_var = null;
			}
		}
	} /* class PXUser */
}
