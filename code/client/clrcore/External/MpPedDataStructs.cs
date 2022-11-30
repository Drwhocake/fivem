using System;
using System.Runtime.InteropServices;
using System.Security;

#if MONO_V2
namespace CitizenFX.FiveM
#else
namespace CitizenFX.Core
#endif
{
	/// <summary>
	/// This is used to GET the data. The GetData() function returns the data into a usable struct for scripts to use safely.
	/// </summary>
	[StructLayout(LayoutKind.Explicit, Size = 0x50)]
	[SecurityCritical]
	internal unsafe struct UnsafePedHeadBlendData
	{
		[FieldOffset(0x00)] private int firstFaceShape;

		[FieldOffset(0x08)] private int secondFaceShape;

		[FieldOffset(0x10)] private int thirdFaceShape;

		[FieldOffset(0x18)] private int firstSkinTone;

		[FieldOffset(0x20)] private int secondSkinTone;

		[FieldOffset(0x28)] private int thirdSkinTone;

		[FieldOffset(0x30)] private float parentFaceShapePercent;

		[FieldOffset(0x38)] private float parentSkinTonePercent;

		[FieldOffset(0x40)] private float parentThirdUnkPercent;

		[FieldOffset(0x48)] private bool isParentInheritance;

		public PedHeadBlendData GetData()
		{
			return new PedHeadBlendData(firstFaceShape, secondFaceShape, thirdFaceShape, firstSkinTone, secondSkinTone, thirdSkinTone, parentFaceShapePercent, parentSkinTonePercent, parentThirdUnkPercent, isParentInheritance);
		}
	}

	/// <summary>
	/// A struct containing all ped head blend data. Used for MP (freemode) characters.
	/// </summary>
	public struct PedHeadBlendData
	{
		public int FirstFaceShape { get; }
		public int SecondFaceShape { get; }
		public int ThirdFaceShape { get; }
		public int FirstSkinTone { get; }
		public int SecondSkinTone { get; }
		public int ThirdSkinTone { get; }
		public float ParentFaceShapePercent { get; }
		public float ParentSkinTonePercent { get; }
		public float ParentThirdUnkPercent { get; }
		public bool IsParentInheritance { get; }

		public PedHeadBlendData(int firstFaceShape, int secondFaceShape, int thirdFaceShape, int firstSkinTone, int secondSkinTone, int thirdSkinTone, float parentFaceShapePercent, float parentSkinTonePercent, float parentThirdUnkPercent, bool isParentInheritance)
		{
			FirstFaceShape = firstFaceShape;
			SecondFaceShape = secondFaceShape;
			ThirdFaceShape = thirdFaceShape;
			FirstSkinTone = firstSkinTone;
			SecondSkinTone = secondSkinTone;
			ThirdSkinTone = thirdSkinTone;
			ParentFaceShapePercent = parentFaceShapePercent;
			ParentSkinTonePercent = parentSkinTonePercent;
			ParentThirdUnkPercent = parentThirdUnkPercent;
			IsParentInheritance = isParentInheritance;
		}
	}

	public enum TattooZoneData
	{
		ZONE_TORSO = 0,
		ZONE_HEAD = 1,
		ZONE_LEFT_ARM = 2,
		ZONE_RIGHT_ARM = 3,
		ZONE_LEFT_LEG = 4,
		ZONE_RIGHT_LEG = 5,
		ZONE_UNKNOWN = 6,
		ZONE_NONE = 7,
	};

	/// <summary>
	/// This is used to GET the data. The GetData() function returns the data into a usable struct for scripts to use safely.
	/// </summary>
	[StructLayout(LayoutKind.Explicit, Size = 0x40)]
	[SecurityCritical]
	internal unsafe struct UnsafeTattooCollectionData
	{
		[FieldOffset(0x00)] private uint unkHash1;

		[FieldOffset(0x08)] private uint unkHash2;

		[FieldOffset(0x10)] private uint tattooCollectionHash;

		[FieldOffset(0x18)] private uint tattooNameHash;

		[FieldOffset(0x20)] private uint unkHash3;

		[FieldOffset(0x28)] private TattooZoneData tattooZoneId;

		[FieldOffset(0x30)] private uint unkHash4;

		[FieldOffset(0x38)] private uint unkHash5;

		public TattooCollectionData GetData()
		{
			return new TattooCollectionData(unkHash1, unkHash2, tattooCollectionHash, tattooNameHash, unkHash3, tattooZoneId, unkHash4, unkHash5);
		}
	}

	public struct TattooCollectionData
	{
		public uint UnkHash1;
		public uint UnkHash2;
		public uint TattooCollectionHash;
		public uint TattooNameHash;
		public uint UnkHash3;
		public TattooZoneData TattooZone;
		public uint UnkHash4;
		public uint UnkHash5;

		public TattooCollectionData(uint unk1, uint unk2, uint collectionHash, uint nameHash, uint unk3, TattooZoneData zone, uint unk4, uint unk5)
		{
			UnkHash1 = unk1;
			UnkHash2 = unk2;
			UnkHash3 = unk3;
			UnkHash4 = unk4;
			UnkHash5 = unk5;
			TattooCollectionHash = collectionHash;
			TattooNameHash = nameHash;
			TattooZone = zone;
		}
	}

	[StructLayout(LayoutKind.Explicit, Size = 0x30)]
	[SecuritySafeCritical]
	internal unsafe struct UnsafeAltPropVariationData
	{
		[FieldOffset(0x00)] private uint unkHash1;

		[FieldOffset(0x08)] private uint unkHash2;

		[FieldOffset(0x10)] private int unkInt1;

		[FieldOffset(0x18)] private int altPropIndex;

		[FieldOffset(0x20)] private int altPropTextureIndex;

		[FieldOffset(0x28)] private int unkInt2;

		public AltPropVariationData GetData(uint unk1, int unk2, int unk3)
		{
			return new AltPropVariationData(unkHash1, unkHash2, unkInt1, altPropIndex, altPropTextureIndex, unkInt2, unk1, unk2, unk3);
		}
	}

	public struct AltPropVariationData
	{
		public uint unknownHash1;
		public uint unknownHash2;
		public uint unknownHash3;
		public int unknownInt1;
		public int unknownInt2;
		public int unknownInt3;
		public int unknownInt4;
		public int altPropVariationIndex;
		public int altPropVariationTexture;

		public AltPropVariationData(uint unknownHash1, uint unknownHash2, int unknownInt1, int altPropVariationIndex, int altPropVariationTexture, int unknownInt2, uint unknownHash3, int unknownInt3, int unknownInt4)
		{
			this.unknownHash1 = unknownHash1;
			this.unknownHash2 = unknownHash2;
			this.unknownInt1 = unknownInt1;
			this.altPropVariationIndex = altPropVariationIndex;
			this.altPropVariationTexture = altPropVariationTexture;
			this.unknownInt2 = unknownInt2;
			this.unknownHash3 = unknownHash3;
			this.unknownInt3 = unknownInt3;
			this.unknownInt4 = unknownInt4;
		}
	}

	[StructLayout(LayoutKind.Explicit, Size = 0x88)]
	[SecuritySafeCritical]
	internal unsafe struct UnsafePedComponentData
	    {
        [FieldOffset(0x00)] private int lockHash;

        [FieldOffset(0x08)] private int hash; // componentHash

        [FieldOffset(0x10)] private int locate;

        [FieldOffset(0x18)] private int drawable;

        [FieldOffset(0x20)] private int texture;

        [FieldOffset(0x28)] private int f_5; // price

        [FieldOffset(0x30)] private int componentType;

        [FieldOffset(0x38)] private int f_7;

        [FieldOffset(0x40)] private int f_8;

        [FieldOffset(0x48)] private unsafe fixed sbyte gxt[0x40];

		[FieldOffset(0x88)] private int f_10;

		public PedComponentData GetData()
		{
			return new PedComponentData(lockHash, hash, locate, drawable, texture, f_5, componentType, f_7, f_8, gxt, f_10);
		}

	}

	public struct PedComponentData
	{
		public int LockHash;
		public int Hash;
		public int Locate;
		public int Drawable;
		public int Texture;
		public int Price;
		public int ComponentType;
		public int Unknown7;
		public int Unknown8;
		public string GXT;
		public int Unknown10;

		public PedComponentData(int lockHash, int hash, int locate, int drawable, int texture, int price, int componentType, int unknown7, int unknown8, sbyte* gxt, int unknown10)
		{
			LockHash = lockHash;
			Hash = hash;
			Locate = locate;
			Drawable = drawable;
			Texture = texture;
			Price = price;
			ComponentType = componentType;
			Unknown7 = unknown7;
			Unknown8 = unknown8;
			GXT = gxt;
			Unknown10 = unknown10;
		}
	}

}
