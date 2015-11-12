namespace Wiki.Data.Enums
{
    using System.ComponentModel;

	/// <summary>
    /// Wikidata property: https://www.wikidata.org/wiki/Help:Properties
    /// </summary>
    public enum Property
	{
		/// <summary>Wikidata property (P6) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HeadOfGovernment = 6,

		/// <summary>Wikidata property (P7) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Brother = 7,

		/// <summary>Wikidata property (P9) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Sister = 9,

		/// <summary>Wikidata property (P10) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		Video = 10,

		/// <summary>Wikidata property (P14) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		HighwayMarker = 14,

		/// <summary>Wikidata property (P15) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		RoadMap = 15,

		/// <summary>Wikidata property (P16) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HighwaySystem = 16,

		/// <summary>Wikidata property (P17) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Country = 17,

		/// <summary>Wikidata property (P18) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		Image = 18,

		/// <summary>Wikidata property (P19) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PlaceOfBirth = 19,

		/// <summary>Wikidata property (P20) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PlaceOfDeath = 20,

		/// <summary>Wikidata property (P21) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SexOrGender = 21,

		/// <summary>Wikidata property (P22) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Father = 22,

		/// <summary>Wikidata property (P25) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Mother = 25,

		/// <summary>Wikidata property (P26) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Spouse = 26,

		/// <summary>Wikidata property (P27) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CountryOfCitizenship = 27,

		/// <summary>Wikidata property (P30) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Continent = 30,

		/// <summary>Wikidata property (P31) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		InstanceOf = 31,

		/// <summary>Wikidata property (P35) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HeadOfState = 35,

		/// <summary>Wikidata property (P36) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Capital = 36,

		/// <summary>Wikidata property (P37) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OfficialLanguage = 37,

		/// <summary>Wikidata property (P38) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Currency = 38,

		/// <summary>Wikidata property (P39) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PositionHeld = 39,

		/// <summary>Wikidata property (P40) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Child = 40,

		/// <summary>Wikidata property (P41) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		FlagImage = 41,

		/// <summary>Wikidata property (P43) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Stepfather = 43,

		/// <summary>Wikidata property (P44) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Stepmother = 44,

		/// <summary>Wikidata property (P47) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SharesBorderWith = 47,

		/// <summary>Wikidata property (P50) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Author = 50,

		/// <summary>Wikidata property (P51) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		Audio = 51,

		/// <summary>Wikidata property (P53) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		NobleFamily = 53,

		/// <summary>Wikidata property (P54) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MemberOfSportsTeam = 54,

		/// <summary>Wikidata property (P57) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Director = 57,

		/// <summary>Wikidata property (P58) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Screenwriter = 58,

		/// <summary>Wikidata property (P59) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Constellation = 59,

		/// <summary>Wikidata property (P61) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DiscovererOrInventor = 61,

		/// <summary>Wikidata property (P65) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SiteOfAstronomicalDiscovery = 65,

		/// <summary>Wikidata property (P66) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AncestralHome = 66,

		/// <summary>Wikidata property (P69) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		EducatedAt = 69,

		/// <summary>Wikidata property (P78) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TopLevelDomain = 78,

		/// <summary>Wikidata property (P81) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ConnectingLine = 81,

		/// <summary>Wikidata property (P84) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Architect = 84,

		/// <summary>Wikidata property (P85) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Anthem = 85,

		/// <summary>Wikidata property (P86) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Composer = 86,

		/// <summary>Wikidata property (P87) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Librettist = 87,

		/// <summary>Wikidata property (P88) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CommissionedBy = 88,

		/// <summary>Wikidata property (P91) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SexualOrientation = 91,

		/// <summary>Wikidata property (P92) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MainRegulatoryText = 92,

		/// <summary>Wikidata property (P94) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		CoatOfArmsImage = 94,

		/// <summary>Wikidata property (P97) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		NobleTitle = 97,

		/// <summary>Wikidata property (P98) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Editor = 98,

		/// <summary>Wikidata property (P101) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FieldOfWork = 101,

		/// <summary>Wikidata property (P102) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MemberOfPoliticalParty = 102,

		/// <summary>Wikidata property (P103) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		NativeLanguage = 103,

		/// <summary>Wikidata property (P105) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TaxonRank = 105,

		/// <summary>Wikidata property (P106) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Occupation = 106,

		/// <summary>Wikidata property (P108) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Employer = 108,

		/// <summary>Wikidata property (P109) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		Signature = 109,

		/// <summary>Wikidata property (P110) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Illustrator = 110,

		/// <summary>Wikidata property (P111) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MeasuredPhysicalQuantity = 111,

		/// <summary>Wikidata property (P112) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Founder = 112,

		/// <summary>Wikidata property (P113) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AirlineHub = 113,

		/// <summary>Wikidata property (P114) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AirlineAlliance = 114,

		/// <summary>Wikidata property (P115) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HomeVenue = 115,

		/// <summary>Wikidata property (P117) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		ChemicalStructure = 117,

		/// <summary>Wikidata property (P118) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		League = 118,

		/// <summary>Wikidata property (P119) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PlaceOfBurial = 119,

		/// <summary>Wikidata property (P121) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ItemOperated = 121,

		/// <summary>Wikidata property (P122) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		BasicFormOfGovernment = 122,

		/// <summary>Wikidata property (P123) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Publisher = 123,

		/// <summary>Wikidata property (P126) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MaintainedBy = 126,

		/// <summary>Wikidata property (P127) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OwnedBy = 127,

		/// <summary>Wikidata property (P128) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		RegulatesMolecularBiology = 128,

		/// <summary>Wikidata property (P129) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PhysicallyInteractsWith = 129,

		/// <summary>Wikidata property (P131) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LocatedInTheAdministrativeTerritorialEntity = 131,

		/// <summary>Wikidata property (P134) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HasDialect = 134,

		/// <summary>Wikidata property (P135) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Movement = 135,

		/// <summary>Wikidata property (P136) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Genre = 136,

		/// <summary>Wikidata property (P137) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Operator = 137,

		/// <summary>Wikidata property (P138) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		NamedAfter = 138,

		/// <summary>Wikidata property (P140) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Religion = 140,

		/// <summary>Wikidata property (P141) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		IUCNConservationStatus = 141,

		/// <summary>Wikidata property (P143) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ImportedFrom = 143,

		/// <summary>Wikidata property (P144) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		BasedOn = 144,

		/// <summary>Wikidata property (P149) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ArchitecturalStyle = 149,

		/// <summary>Wikidata property (P150) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ContainsAdministrativeTerritorialEntity = 150,

		/// <summary>Wikidata property (P154) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		LogoImage = 154,

		/// <summary>Wikidata property (P155) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Follows = 155,

		/// <summary>Wikidata property (P156) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FollowedBy = 156,

		/// <summary>Wikidata property (P157) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		KilledBy = 157,

		/// <summary>Wikidata property (P158) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		SealImage = 158,

		/// <summary>Wikidata property (P159) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HeadquartersLocation = 159,

		/// <summary>Wikidata property (P161) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CastMember = 161,

		/// <summary>Wikidata property (P162) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Producer = 162,

		/// <summary>Wikidata property (P163) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Flag = 163,

		/// <summary>Wikidata property (P166) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AwardReceived = 166,

		/// <summary>Wikidata property (P167) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		StructureReplacedBy = 167,

		/// <summary>Wikidata property (P169) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ChiefExecutiveOfficer = 169,

		/// <summary>Wikidata property (P170) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Creator = 170,

		/// <summary>Wikidata property (P171) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ParentTaxon = 171,

		/// <summary>Wikidata property (P172) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		EthnicGroup = 172,

		/// <summary>Wikidata property (P175) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Performer = 175,

		/// <summary>Wikidata property (P176) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Manufacturer = 176,

		/// <summary>Wikidata property (P177) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Crosses = 177,

		/// <summary>Wikidata property (P178) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Developer = 178,

		/// <summary>Wikidata property (P179) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Series = 179,

		/// <summary>Wikidata property (P180) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Depicts = 180,

		/// <summary>Wikidata property (P181) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		TaxonRangeMapImage = 181,

		/// <summary>Wikidata property (P183) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		EndemicTo = 183,

		/// <summary>Wikidata property (P184) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DoctoralAdvisor = 184,

		/// <summary>Wikidata property (P185) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DoctoralStudent = 185,

		/// <summary>Wikidata property (P186) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MaterialUsed = 186,

		/// <summary>Wikidata property (P189) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LocationOfDiscovery = 189,

		/// <summary>Wikidata property (P190) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SisterCity = 190,

		/// <summary>Wikidata property (P193) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MainBuildingContractor = 193,

		/// <summary>Wikidata property (P194) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LegislativeBody = 194,

		/// <summary>Wikidata property (P195) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Collection = 195,

		/// <summary>Wikidata property (P196) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MinorPlanetGroup = 196,

		/// <summary>Wikidata property (P197) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AdjacentStation = 197,

		/// <summary>Wikidata property (P199) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		BusinessDivision = 199,

		/// <summary>Wikidata property (P200) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LakeInflows = 200,

		/// <summary>Wikidata property (P201) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LakeOutflow = 201,

		/// <summary>Wikidata property (P205) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		BasinCountry = 205,

		/// <summary>Wikidata property (P206) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LocatedNextToBodyOfWater = 206,

		/// <summary>Wikidata property (P207) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		BathymetryImage = 207,

		/// <summary>Wikidata property (P208) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ExecutiveBody = 208,

		/// <summary>Wikidata property (P209) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HighestJudicialAuthority = 209,

		/// <summary>Wikidata property (P210) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PartyChiefRepresentative = 210,

		/// <summary>Wikidata property (P212) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISBN13 = 212,

		/// <summary>Wikidata property (P213) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISNI = 213,

		/// <summary>Wikidata property (P214) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		VIAFIdentifier = 214,

		/// <summary>Wikidata property (P215) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SpectralClass = 215,

		/// <summary>Wikidata property (P217) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		InventoryNumber = 217,

		/// <summary>Wikidata property (P218) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISO6391Code = 218,

		/// <summary>Wikidata property (P219) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISO6392Code = 219,

		/// <summary>Wikidata property (P220) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISO6393Code = 220,

		/// <summary>Wikidata property (P221) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISO6396Code = 221,

		/// <summary>Wikidata property (P223) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GalaxyMorphologicalType = 223,

		/// <summary>Wikidata property (P225) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TaxonName = 225,

		/// <summary>Wikidata property (P227) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GNDIdentifier = 227,

		/// <summary>Wikidata property (P229) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IATAAirlineDesignator = 229,

		/// <summary>Wikidata property (P230) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ICAOAirlineDesignator = 230,

		/// <summary>Wikidata property (P231) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CASRegistryNumber = 231,

		/// <summary>Wikidata property (P232) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EINECSNumber = 232,

		/// <summary>Wikidata property (P233) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CanonicalSMILES = 233,

		/// <summary>Wikidata property (P234) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		InChI = 234,

		/// <summary>Wikidata property (P235) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		InChIKey = 235,

		/// <summary>Wikidata property (P236) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISSN = 236,

		/// <summary>Wikidata property (P237) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CoatOfArms = 237,

		/// <summary>Wikidata property (P238) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IATAAirportCode = 238,

		/// <summary>Wikidata property (P239) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ICAOAirportCode = 239,

		/// <summary>Wikidata property (P240) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FAAAirportCode = 240,

		/// <summary>Wikidata property (P241) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MilitaryBranch = 241,

		/// <summary>Wikidata property (P242) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		LocatorMapImage = 242,

		/// <summary>Wikidata property (P243) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OCLCControlNumber = 243,

		/// <summary>Wikidata property (P244) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LCAuthIdentifier = 244,

		/// <summary>Wikidata property (P245) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ULANIdentifier = 245,

		/// <summary>Wikidata property (P246) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ElementSymbol = 246,

		/// <summary>Wikidata property (P247) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		COSPARID = 247,

		/// <summary>Wikidata property (P248) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		StatedIn = 248,

		/// <summary>Wikidata property (P249) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TickerSymbol = 249,

		/// <summary>Wikidata property (P263) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OfficialResidence = 263,

		/// <summary>Wikidata property (P264) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		RecordLabel = 264,

		/// <summary>Wikidata property (P267) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ATCCode = 267,

		/// <summary>Wikidata property (P268) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BnFIdentifier = 268,

		/// <summary>Wikidata property (P269) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SUDOCAuthorities = 269,

		/// <summary>Wikidata property (P270) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CALIS = 270,

		/// <summary>Wikidata property (P271) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CiNiiAuthorIdentifier = 271,

		/// <summary>Wikidata property (P272) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ProductionCompany = 272,

		/// <summary>Wikidata property (P274) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ChemicalFormula = 274,

		/// <summary>Wikidata property (P275) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		License = 275,

		/// <summary>Wikidata property (P276) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Location = 276,

		/// <summary>Wikidata property (P277) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ProgrammingLanguage = 277,

		/// <summary>Wikidata property (P278) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GOST77597Code = 278,

		/// <summary>Wikidata property (P279) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SubclassOf = 279,

		/// <summary>Wikidata property (P281) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PostalCode = 281,

		/// <summary>Wikidata property (P282) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		WritingSystem = 282,

		/// <summary>Wikidata property (P286) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HeadCoach = 286,

		/// <summary>Wikidata property (P287) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Designer = 287,

		/// <summary>Wikidata property (P289) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		VesselClass = 289,

		/// <summary>Wikidata property (P291) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PlaceOfPublication = 291,

		/// <summary>Wikidata property (P296) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		StationCode = 296,

		/// <summary>Wikidata property (P297) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISO31661Alpha2Code = 297,

		/// <summary>Wikidata property (P298) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISO31661Alpha3Code = 298,

		/// <summary>Wikidata property (P299) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISO31661NumericCode = 299,

		/// <summary>Wikidata property (P300) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISO31662Code = 300,

		/// <summary>Wikidata property (P301) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CategorysMainTopic = 301,

		/// <summary>Wikidata property (P303) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EEBreedNumber = 303,

		/// <summary>Wikidata property (P304) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Page = 304,

		/// <summary>Wikidata property (P305) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IETFLanguageTag = 305,

		/// <summary>Wikidata property (P306) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OperatingSystem = 306,

		/// <summary>Wikidata property (P344) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DirectorOfPhotography = 344,

		/// <summary>Wikidata property (P345) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IMDbIdentifier = 345,

		/// <summary>Wikidata property (P347) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		JocondeID = 347,

		/// <summary>Wikidata property (P348) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SoftwareVersion = 348,

		/// <summary>Wikidata property (P349) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NDLIdentifier = 349,

		/// <summary>Wikidata property (P350) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RKDimages = 350,

		/// <summary>Wikidata property (P351) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EntrezGeneID = 351,

		/// <summary>Wikidata property (P352) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UniProtID = 352,

		/// <summary>Wikidata property (P353) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GeneSymbol = 353,

		/// <summary>Wikidata property (P354) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HGNCID = 354,

		/// <summary>Wikidata property (P355) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Subsidiaries = 355,

		/// <summary>Wikidata property (P356) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DOI = 356,

		/// <summary>Wikidata property (P357) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OBSOLETETitleUseP1476Title = 357,

		/// <summary>Wikidata property (P358) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Discography = 358,

		/// <summary>Wikidata property (P359) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RijksmonumentIdentifier = 359,

		/// <summary>Wikidata property (P360) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		IsAListOf = 360,

		/// <summary>Wikidata property (P361) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PartOf = 361,

		/// <summary>Wikidata property (P364) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OriginalLanguageOfWork = 364,

		/// <summary>Wikidata property (P366) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Use = 366,

		/// <summary>Wikidata property (P367) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		AstronomicSymbolImage = 367,

		/// <summary>Wikidata property (P368) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		SandboxCommonsMediaFile = 368,

		/// <summary>Wikidata property (P369) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SandboxItem = 369,

		/// <summary>Wikidata property (P370) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SandboxString = 370,

		/// <summary>Wikidata property (P371) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Presenter = 371,

		/// <summary>Wikidata property (P373) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CommonsCategory = 373,

		/// <summary>Wikidata property (P374) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		INSEEMunicipalityCode = 374,

		/// <summary>Wikidata property (P375) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SpaceLaunchVehicle = 375,

		/// <summary>Wikidata property (P376) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LocatedOnAstronomicalBody = 376,

		/// <summary>Wikidata property (P377) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SCN = 377,

		/// <summary>Wikidata property (P380) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MerimeeIdentifier = 380,

		/// <summary>Wikidata property (P381) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PCPReferenceNumber = 381,

		/// <summary>Wikidata property (P382) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CBSMunicipalityCode = 382,

		/// <summary>Wikidata property (P387) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OBSOLETEQuoteUseP1683 = 387,

		/// <summary>Wikidata property (P393) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EditionNumber = 393,

		/// <summary>Wikidata property (P395) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LicencePlateCode = 395,

		/// <summary>Wikidata property (P396) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SBNIdentifier = 396,

		/// <summary>Wikidata property (P397) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AstronomicalBody = 397,

		/// <summary>Wikidata property (P398) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ChildAstronomicalBody = 398,

		/// <summary>Wikidata property (P399) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CompanionOf = 399,

		/// <summary>Wikidata property (P400) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Platform = 400,

		/// <summary>Wikidata property (P402) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OpenStreetMapRelationIdentifier = 402,

		/// <summary>Wikidata property (P403) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MouthOfTheWatercourse = 403,

		/// <summary>Wikidata property (P404) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		GameMode = 404,

		/// <summary>Wikidata property (P405) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TaxonAuthor = 405,

		/// <summary>Wikidata property (P406) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SoundtrackAlbum = 406,

		/// <summary>Wikidata property (P407) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LanguageOfWorkOrName = 407,

		/// <summary>Wikidata property (P408) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SoftwareEngine = 408,

		/// <summary>Wikidata property (P409) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NLAAustraliaIdentifier = 409,

		/// <summary>Wikidata property (P410) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MilitaryRank = 410,

		/// <summary>Wikidata property (P411) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CanonizationStatus = 411,

		/// <summary>Wikidata property (P412) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		VoiceType = 412,

		/// <summary>Wikidata property (P413) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PositionPlayedOnTeamSpeciality = 413,

		/// <summary>Wikidata property (P414) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		StockExchange = 414,

		/// <summary>Wikidata property (P415) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		RadioFormat = 415,

		/// <summary>Wikidata property (P416) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		QuantitySymbol = 416,

		/// <summary>Wikidata property (P417) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PatronSaint = 417,

		/// <summary>Wikidata property (P418) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SealDescription = 418,

		/// <summary>Wikidata property (P421) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LocatedInTimeZone = 421,

		/// <summary>Wikidata property (P423) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ShootingHandedness = 423,

		/// <summary>Wikidata property (P424) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WikimediaLanguageCode = 424,

		/// <summary>Wikidata property (P425) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FieldOfThisProfession = 425,

		/// <summary>Wikidata property (P426) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AircraftRegistration = 426,

		/// <summary>Wikidata property (P427) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TaxonomicType = 427,

		/// <summary>Wikidata property (P428) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BotanistAuthorAbbreviation = 428,

		/// <summary>Wikidata property (P429) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DantaiCode = 429,

		/// <summary>Wikidata property (P432) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CallsignOfAirline = 432,

		/// <summary>Wikidata property (P433) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Issue = 433,

		/// <summary>Wikidata property (P434) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MusicBrainzArtistID = 434,

		/// <summary>Wikidata property (P435) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MusicBrainzWorkID = 435,

		/// <summary>Wikidata property (P436) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MusicBrainzReleaseGroupID = 436,

		/// <summary>Wikidata property (P437) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Distribution = 437,

		/// <summary>Wikidata property (P438) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OBSOLETEInscriptionUseP1684 = 438,

		/// <summary>Wikidata property (P439) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GermanMunicipalityKey = 439,

		/// <summary>Wikidata property (P440) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GermanDistrictKey = 440,

		/// <summary>Wikidata property (P442) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ChinaAdministrativeDivisionCode = 442,

		/// <summary>Wikidata property (P443) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		PronunciationAudio = 443,

		/// <summary>Wikidata property (P444) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ReviewScore = 444,

		/// <summary>Wikidata property (P447) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ScoreBy = 447,

		/// <summary>Wikidata property (P448) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LocationOfSpacecraftLaunch = 448,

		/// <summary>Wikidata property (P449) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OriginalNetwork = 449,

		/// <summary>Wikidata property (P450) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AstronautMission = 450,

		/// <summary>Wikidata property (P451) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Cohabitant = 451,

		/// <summary>Wikidata property (P452) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Industry = 452,

		/// <summary>Wikidata property (P453) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CharacterRole = 453,

		/// <summary>Wikidata property (P454) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		StructuraeIDStructure = 454,

		/// <summary>Wikidata property (P455) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EmporisBuildingID = 455,

		/// <summary>Wikidata property (P457) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FoundationalText = 457,

		/// <summary>Wikidata property (P458) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IMOShipNumber = 458,

		/// <summary>Wikidata property (P459) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DeterminationMethod = 459,

		/// <summary>Wikidata property (P460) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SaidToBeTheSameAs = 460,

		/// <summary>Wikidata property (P461) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OppositeOf = 461,

		/// <summary>Wikidata property (P462) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Color = 462,

		/// <summary>Wikidata property (P463) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MemberOf = 463,

		/// <summary>Wikidata property (P464) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NOR = 464,

		/// <summary>Wikidata property (P465) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SRGBColorHexTriplet = 465,

		/// <summary>Wikidata property (P466) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Occupant = 466,

		/// <summary>Wikidata property (P467) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LegislatedBy = 467,

		/// <summary>Wikidata property (P468) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DanKyuRank = 468,

		/// <summary>Wikidata property (P469) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LakesOnRiver = 469,

		/// <summary>Wikidata property (P470) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		EightBannerRegister = 470,

		/// <summary>Wikidata property (P473) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LocalDialingCode = 473,

		/// <summary>Wikidata property (P474) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CountryCallingCode = 474,

		/// <summary>Wikidata property (P476) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CELEXNumber = 476,

		/// <summary>Wikidata property (P477) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CanadianRegisterOfHistoricPlacesIdentifier = 477,

		/// <summary>Wikidata property (P478) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Volume = 478,

		/// <summary>Wikidata property (P479) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		InputDevice = 479,

		/// <summary>Wikidata property (P480) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FilmAffinityIdentifier = 480,

		/// <summary>Wikidata property (P481) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PalissyIdentifier = 481,

		/// <summary>Wikidata property (P483) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		RecordedAt = 483,

		/// <summary>Wikidata property (P484) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IMANumberBroadSense = 484,

		/// <summary>Wikidata property (P485) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ArchivesAt = 485,

		/// <summary>Wikidata property (P486) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MeSHID = 486,

		/// <summary>Wikidata property (P487) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UnicodeCharacter = 487,

		/// <summary>Wikidata property (P488) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Chairperson = 488,

		/// <summary>Wikidata property (P489) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CurrencySymbolDescription = 489,

		/// <summary>Wikidata property (P490) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ProvisionalDesignation = 490,

		/// <summary>Wikidata property (P491) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		OrbitDiagram = 491,

		/// <summary>Wikidata property (P492) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OMIMID = 492,

		/// <summary>Wikidata property (P493) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ICD9 = 493,

		/// <summary>Wikidata property (P494) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ICD10 = 494,

		/// <summary>Wikidata property (P495) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CountryOfOrigin = 495,

		/// <summary>Wikidata property (P496) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ORCID = 496,

		/// <summary>Wikidata property (P497) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CBDBID = 497,

		/// <summary>Wikidata property (P498) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISO4217Code = 498,

		/// <summary>Wikidata property (P500) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ExclaveOf = 500,

		/// <summary>Wikidata property (P501) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		EnclaveWithin = 501,

		/// <summary>Wikidata property (P502) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HURDATIdentifier = 502,

		/// <summary>Wikidata property (P503) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISOStandard = 503,

		/// <summary>Wikidata property (P504) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HomePort = 504,

		/// <summary>Wikidata property (P505) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		GeneralManager = 505,

		/// <summary>Wikidata property (P506) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISO15924Alpha4OrNumericCode = 506,

		/// <summary>Wikidata property (P507) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SwedishCountyCode = 507,

		/// <summary>Wikidata property (P508) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PIJAS = 508,

		/// <summary>Wikidata property (P509) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CauseOfDeath = 509,

		/// <summary>Wikidata property (P511) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HonorificPrefix = 511,

		/// <summary>Wikidata property (P512) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AcademicDegree = 512,

		/// <summary>Wikidata property (P513) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OBSOLETEBirthNameUseP1477 = 513,

		/// <summary>Wikidata property (P514) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		InterleavesWith = 514,

		/// <summary>Wikidata property (P515) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PhaseOfMatter = 515,

		/// <summary>Wikidata property (P516) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Powerplant = 516,

		/// <summary>Wikidata property (P517) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Interaction = 517,

		/// <summary>Wikidata property (P518) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AppliesToPart = 518,

		/// <summary>Wikidata property (P520) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Armament = 520,

		/// <summary>Wikidata property (P521) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ScheduledServiceDestination = 521,

		/// <summary>Wikidata property (P522) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TypeOfOrbit = 522,

		/// <summary>Wikidata property (P523) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TemporalRangeStart = 523,

		/// <summary>Wikidata property (P524) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TemporalRangeEnd = 524,

		/// <summary>Wikidata property (P525) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SwedishMunicipalityCode = 525,

		/// <summary>Wikidata property (P527) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HasPart = 527,

		/// <summary>Wikidata property (P528) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CatalogCode = 528,

		/// <summary>Wikidata property (P529) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Runway = 529,

		/// <summary>Wikidata property (P530) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DiplomaticRelation = 530,

		/// <summary>Wikidata property (P531) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DiplomaticMissionSent = 531,

		/// <summary>Wikidata property (P532) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PortOfRegistry = 532,

		/// <summary>Wikidata property (P533) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Target = 533,

		/// <summary>Wikidata property (P534) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		StreakColor = 534,

		/// <summary>Wikidata property (P535) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FindAGraveGraveID = 535,

		/// <summary>Wikidata property (P536) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ATPID = 536,

		/// <summary>Wikidata property (P537) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Twinning = 537,

		/// <summary>Wikidata property (P538) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Fracturing = 538,

		/// <summary>Wikidata property (P539) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Museofile = 539,

		/// <summary>Wikidata property (P541) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OfficeContested = 541,

		/// <summary>Wikidata property (P542) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OfficiallyOpenedBy = 542,

		/// <summary>Wikidata property (P543) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OathMadeBy = 543,

		/// <summary>Wikidata property (P545) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TorchLitBy = 545,

		/// <summary>Wikidata property (P546) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DockingPort = 546,

		/// <summary>Wikidata property (P547) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Commemorates = 547,

		/// <summary>Wikidata property (P548) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		VersionType = 548,

		/// <summary>Wikidata property (P549) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MathematicsGenealogyProjectIdentifier = 549,

		/// <summary>Wikidata property (P550) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ChivalricOrder = 550,

		/// <summary>Wikidata property (P551) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Residence = 551,

		/// <summary>Wikidata property (P552) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Handedness = 552,

		/// <summary>Wikidata property (P553) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		WebsiteAccountOn = 553,

		/// <summary>Wikidata property (P554) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WebsiteUsername = 554,

		/// <summary>Wikidata property (P555) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DoublesRecord = 555,

		/// <summary>Wikidata property (P556) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CrystalSystem = 556,

		/// <summary>Wikidata property (P557) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DiseasesDB = 557,

		/// <summary>Wikidata property (P558) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UnitSymbol = 558,

		/// <summary>Wikidata property (P559) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Terminus = 559,

		/// <summary>Wikidata property (P560) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Direction = 560,

		/// <summary>Wikidata property (P561) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NATOReportingName = 561,

		/// <summary>Wikidata property (P562) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CentralBankIssuer = 562,

		/// <summary>Wikidata property (P563) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ICDO = 563,

		/// <summary>Wikidata property (P564) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SinglesRecord = 564,

		/// <summary>Wikidata property (P565) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CrystalHabit = 565,

		/// <summary>Wikidata property (P566) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Basionym = 566,

		/// <summary>Wikidata property (P567) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Underlies = 567,

		/// <summary>Wikidata property (P568) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Overlies = 568,

		/// <summary>Wikidata property (P569) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		DateOfBirth = 569,

		/// <summary>Wikidata property (P570) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		DateOfDeath = 570,

		/// <summary>Wikidata property (P571) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		Inception = 571,

		/// <summary>Wikidata property (P574) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		DateOfTaxonNamePublication = 574,

		/// <summary>Wikidata property (P575) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		TimeOfDiscovery = 575,

		/// <summary>Wikidata property (P576) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		DissolvedOrAbolished = 576,

		/// <summary>Wikidata property (P577) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		PublicationDate = 577,

		/// <summary>Wikidata property (P578) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		SandboxTimeValue = 578,

		/// <summary>Wikidata property (P579) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		IMAStatusAndOrRank = 579,

		/// <summary>Wikidata property (P580) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		StartTime = 580,

		/// <summary>Wikidata property (P582) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		EndTime = 582,

		/// <summary>Wikidata property (P585) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		PointInTime = 585,

		/// <summary>Wikidata property (P586) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IPNIAuthorID = 586,

		/// <summary>Wikidata property (P587) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MMSI = 587,

		/// <summary>Wikidata property (P588) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Coolant = 588,

		/// <summary>Wikidata property (P589) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PointGroup = 589,

		/// <summary>Wikidata property (P590) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GNISID = 590,

		/// <summary>Wikidata property (P591) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ECNumber = 591,

		/// <summary>Wikidata property (P592) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ChEMBLID = 592,

		/// <summary>Wikidata property (P593) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HomoloGeneID = 593,

		/// <summary>Wikidata property (P594) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EnsemblGeneID = 594,

		/// <summary>Wikidata property (P595) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IUPHARID = 595,

		/// <summary>Wikidata property (P597) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WTAID = 597,

		/// <summary>Wikidata property (P598) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CommanderOf = 598,

		/// <summary>Wikidata property (P599) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ITFID = 599,

		/// <summary>Wikidata property (P600) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WineAppDBID = 600,

		/// <summary>Wikidata property (P604) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MedlinePlusID = 604,

		/// <summary>Wikidata property (P605) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NUTSCode = 605,

		/// <summary>Wikidata property (P606) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		FirstFlight = 606,

		/// <summary>Wikidata property (P607) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Conflict = 607,

		/// <summary>Wikidata property (P608) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ExhibitionHistory = 608,

		/// <summary>Wikidata property (P609) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TerminusLocation = 609,

		/// <summary>Wikidata property (P610) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HighestPoint = 610,

		/// <summary>Wikidata property (P611) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ReligiousOrder = 611,

		/// <summary>Wikidata property (P612) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MotherHouse = 612,

		/// <summary>Wikidata property (P613) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OSGridReference = 613,

		/// <summary>Wikidata property (P617) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		YardNumber = 617,

		/// <summary>Wikidata property (P618) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SourceOfEnergy = 618,

		/// <summary>Wikidata property (P619) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		TimeOfSpacecraftLaunch = 619,

		/// <summary>Wikidata property (P620) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		TimeOfSpacecraftLanding = 620,

		/// <summary>Wikidata property (P621) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		TimeOfSpacecraftOrbitDecay = 621,

		/// <summary>Wikidata property (P622) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		SpacecraftDockingUndocking = 622,

		/// <summary>Wikidata property (P624) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		GuidanceSystem = 624,

		/// <summary>Wikidata property (P625) of <see cref="DataType.GlobeCoordinate"/></summary>
		[Type(DataType.GlobeCoordinate)]
		CoordinateLocation = 625,

		/// <summary>Wikidata property (P626) of <see cref="DataType.GlobeCoordinate"/></summary>
		[Type(DataType.GlobeCoordinate)]
		SandboxGeoCoordinateValue = 626,

		/// <summary>Wikidata property (P627) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IUCNID = 627,

		/// <summary>Wikidata property (P628) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ENumber = 628,

		/// <summary>Wikidata property (P629) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		EditionOrTranslationOf = 629,

		/// <summary>Wikidata property (P630) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ParisCityDigitalCode = 630,

		/// <summary>Wikidata property (P631) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		StructuralEngineer = 631,

		/// <summary>Wikidata property (P632) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CulturalPropertiesOfBelarusReferenceNumber = 632,

		/// <summary>Wikidata property (P633) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		QuebecCulturalHeritageDirectoryIdentifier = 633,

		/// <summary>Wikidata property (P634) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Captain = 634,

		/// <summary>Wikidata property (P635) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISTATID = 635,

		/// <summary>Wikidata property (P636) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		RouteOfAdministration = 636,

		/// <summary>Wikidata property (P637) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RefSeqProteinID = 637,

		/// <summary>Wikidata property (P638) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PDBID = 638,

		/// <summary>Wikidata property (P639) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RefSeqRNAID = 639,

		/// <summary>Wikidata property (P640) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LeonoreID = 640,

		/// <summary>Wikidata property (P641) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Sport = 641,

		/// <summary>Wikidata property (P642) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Of = 642,

		/// <summary>Wikidata property (P644) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GenomicStart = 644,

		/// <summary>Wikidata property (P645) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GenomicEnd = 645,

		/// <summary>Wikidata property (P646) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FreebaseIdentifier = 646,

		/// <summary>Wikidata property (P647) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DraftedBy = 647,

		/// <summary>Wikidata property (P648) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OpenLibraryIdentifier = 648,

		/// <summary>Wikidata property (P649) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NRHPReferenceNumber = 649,

		/// <summary>Wikidata property (P650) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RKDartists = 650,

		/// <summary>Wikidata property (P651) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BiografischPortaalNumber = 651,

		/// <summary>Wikidata property (P652) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UNII = 652,

		/// <summary>Wikidata property (P653) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PubMedHealth = 653,

		/// <summary>Wikidata property (P654) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DirectionRelativeToLocation = 654,

		/// <summary>Wikidata property (P655) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Translator = 655,

		/// <summary>Wikidata property (P656) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RefSeq = 656,

		/// <summary>Wikidata property (P657) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RTECSNumber = 657,

		/// <summary>Wikidata property (P658) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Tracklist = 658,

		/// <summary>Wikidata property (P659) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		GenLocAssembly = 659,

		/// <summary>Wikidata property (P660) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ECClassification = 660,

		/// <summary>Wikidata property (P661) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ChemSpiderID = 661,

		/// <summary>Wikidata property (P662) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PubChemIDCID = 662,

		/// <summary>Wikidata property (P663) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DSMIV = 663,

		/// <summary>Wikidata property (P664) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Organizer = 664,

		/// <summary>Wikidata property (P665) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KEGGID = 665,

		/// <summary>Wikidata property (P667) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ICPC2ID = 667,

		/// <summary>Wikidata property (P668) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GeneReviewsID = 668,

		/// <summary>Wikidata property (P669) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LocatedOnStreet = 669,

		/// <summary>Wikidata property (P670) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		StreetNumber = 670,

		/// <summary>Wikidata property (P671) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MouseGenomeInformaticsID = 671,

		/// <summary>Wikidata property (P672) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MeSHCode = 672,

		/// <summary>Wikidata property (P673) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EMedicine = 673,

		/// <summary>Wikidata property (P674) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Characters = 674,

		/// <summary>Wikidata property (P675) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GoogleBooksIdentifier = 675,

		/// <summary>Wikidata property (P676) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LyricsBy = 676,

		/// <summary>Wikidata property (P677) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ÚSOPCode = 677,

		/// <summary>Wikidata property (P678) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		IncertaeSedis = 678,

		/// <summary>Wikidata property (P679) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ZVGNumber = 679,

		/// <summary>Wikidata property (P680) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MolecularFunction = 680,

		/// <summary>Wikidata property (P681) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CellComponent = 681,

		/// <summary>Wikidata property (P682) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		BiologicalProcess = 682,

		/// <summary>Wikidata property (P683) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ChEBIID = 683,

		/// <summary>Wikidata property (P684) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Ortholog = 684,

		/// <summary>Wikidata property (P685) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NCBITaxonomyID = 685,

		/// <summary>Wikidata property (P686) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GeneOntologyID = 686,

		/// <summary>Wikidata property (P687) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BHLPageID = 687,

		/// <summary>Wikidata property (P688) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Encodes = 688,

		/// <summary>Wikidata property (P689) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Afflicts = 689,

		/// <summary>Wikidata property (P690) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SpaceGroup = 690,

		/// <summary>Wikidata property (P691) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NKCIdentifier = 691,

		/// <summary>Wikidata property (P692) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		GeneAtlasImage = 692,

		/// <summary>Wikidata property (P693) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Cleavage = 693,

		/// <summary>Wikidata property (P694) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ReplacedSynonymForNomNov = 694,

		/// <summary>Wikidata property (P695) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UNNumber = 695,

		/// <summary>Wikidata property (P696) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NeurolexID = 696,

		/// <summary>Wikidata property (P697) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ExTaxonAuthor = 697,

		/// <summary>Wikidata property (P698) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PubMedID = 698,

		/// <summary>Wikidata property (P699) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DiseaseOntologyID = 699,

		/// <summary>Wikidata property (P700) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KemlerID = 700,

		/// <summary>Wikidata property (P701) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Dodis = 701,

		/// <summary>Wikidata property (P702) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		EncodedBy = 702,

		/// <summary>Wikidata property (P703) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FoundInTaxon = 703,

		/// <summary>Wikidata property (P704) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EnsemblTranscriptID = 704,

		/// <summary>Wikidata property (P705) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EnsemblProteinID = 705,

		/// <summary>Wikidata property (P706) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LocatedOnTerrainFeature = 706,

		/// <summary>Wikidata property (P707) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SatelliteBus = 707,

		/// <summary>Wikidata property (P708) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Diocese = 708,

		/// <summary>Wikidata property (P709) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HistoricScotlandID = 709,

		/// <summary>Wikidata property (P710) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Participant = 710,

		/// <summary>Wikidata property (P711) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Strunz8thEditionSeriesID = 711,

		/// <summary>Wikidata property (P712) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NickelStrunz9thEditionUpdated2009 = 712,

		/// <summary>Wikidata property (P713) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NickelStrunz10thPendingEdition = 713,

		/// <summary>Wikidata property (P714) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Dana8thEdition = 714,

		/// <summary>Wikidata property (P715) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DrugbankID = 715,

		/// <summary>Wikidata property (P716) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		JPLSmallBodyDatabaseIdentifier = 716,

		/// <summary>Wikidata property (P717) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MinorPlanetCenterObservatoryCode = 717,

		/// <summary>Wikidata property (P718) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CanmoreID = 718,

		/// <summary>Wikidata property (P720) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AsteroidSpectralType = 720,

		/// <summary>Wikidata property (P721) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OKATOIdentifier = 721,

		/// <summary>Wikidata property (P722) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UICStationCode = 722,

		/// <summary>Wikidata property (P723) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DBNLID = 723,

		/// <summary>Wikidata property (P724) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		InternetArchiveIdentifier = 724,

		/// <summary>Wikidata property (P725) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		VoiceActor = 725,

		/// <summary>Wikidata property (P726) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Candidate = 726,

		/// <summary>Wikidata property (P727) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EuropeanaID = 727,

		/// <summary>Wikidata property (P728) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GHSHazardStatement = 728,

		/// <summary>Wikidata property (P729) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		ServiceEntry = 729,

		/// <summary>Wikidata property (P730) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		ServiceRetirement = 730,

		/// <summary>Wikidata property (P731) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LitholexID = 731,

		/// <summary>Wikidata property (P732) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BGSLexiconID = 732,

		/// <summary>Wikidata property (P733) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DINOloket = 733,

		/// <summary>Wikidata property (P734) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FamilyName = 734,

		/// <summary>Wikidata property (P735) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		GivenName = 735,

		/// <summary>Wikidata property (P736) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CoverArtist = 736,

		/// <summary>Wikidata property (P737) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		InfluencedBy = 737,

		/// <summary>Wikidata property (P738) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OBSOLETEInfluenceOf = 738,

		/// <summary>Wikidata property (P739) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Ammunition = 739,

		/// <summary>Wikidata property (P740) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LocationOfFormation = 740,

		/// <summary>Wikidata property (P741) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PlayingHand = 741,

		/// <summary>Wikidata property (P742) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Pseudonym = 742,

		/// <summary>Wikidata property (P744) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AsteroidFamily = 744,

		/// <summary>Wikidata property (P745) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LowGermanBibliographyAndBiographyID = 745,

		/// <summary>Wikidata property (P746) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		DateOfDisappearance = 746,

		/// <summary>Wikidata property (P747) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		EditionS = 747,

		/// <summary>Wikidata property (P748) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AppointedBy = 748,

		/// <summary>Wikidata property (P749) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ParentCompany = 749,

		/// <summary>Wikidata property (P750) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Distributor = 750,

		/// <summary>Wikidata property (P751) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		IntroducedFeature = 751,

		/// <summary>Wikidata property (P756) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		RemovedFeature = 756,

		/// <summary>Wikidata property (P757) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WorldHeritageSiteId = 757,

		/// <summary>Wikidata property (P758) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KulturminneIdentifier = 758,

		/// <summary>Wikidata property (P759) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AlbertaRegisterOfHistoricPlacesIdentifier = 759,

		/// <summary>Wikidata property (P760) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DPLAID = 760,

		/// <summary>Wikidata property (P761) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		VISSID = 761,

		/// <summary>Wikidata property (P762) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CzechCulturalHeritageID = 762,

		/// <summary>Wikidata property (P763) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PEIRegisterOfHistoricPlacesIdentifier = 763,

		/// <summary>Wikidata property (P764) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OKTMOIdentifier = 764,

		/// <summary>Wikidata property (P765) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SurfacePlayedOn = 765,

		/// <summary>Wikidata property (P767) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Contributor = 767,

		/// <summary>Wikidata property (P768) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ElectoralDistrict = 768,

		/// <summary>Wikidata property (P769) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SignificantDrugInteraction = 769,

		/// <summary>Wikidata property (P770) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CauseOfDestruction = 770,

		/// <summary>Wikidata property (P771) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SwissMunicipalityCode = 771,

		/// <summary>Wikidata property (P772) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		INEMunicipalityCode = 772,

		/// <summary>Wikidata property (P773) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISO31663 = 773,

		/// <summary>Wikidata property (P774) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FIPS553LocationsInTheUS = 774,

		/// <summary>Wikidata property (P775) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SwedishUrbanAreaCode = 775,

		/// <summary>Wikidata property (P776) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SwedishMinorUrbanAreaCode = 776,

		/// <summary>Wikidata property (P777) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SwedishCivilParishCodeATACode = 777,

		/// <summary>Wikidata property (P778) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ChurchOfSwedenParishCode = 778,

		/// <summary>Wikidata property (P779) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ChurchOfSwedenPastoratskod = 779,

		/// <summary>Wikidata property (P780) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Symptoms = 780,

		/// <summary>Wikidata property (P781) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Sikart = 781,

		/// <summary>Wikidata property (P782) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LAU = 782,

		/// <summary>Wikidata property (P783) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HymeniumType = 783,

		/// <summary>Wikidata property (P784) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MushroomCapShape = 784,

		/// <summary>Wikidata property (P785) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HymeniumAttachment = 785,

		/// <summary>Wikidata property (P786) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		StipeCharacter = 786,

		/// <summary>Wikidata property (P787) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SporePrintColor = 787,

		/// <summary>Wikidata property (P788) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MushroomEcologicalType = 788,

		/// <summary>Wikidata property (P789) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Edibility = 789,

		/// <summary>Wikidata property (P790) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ApprovedBy = 790,

		/// <summary>Wikidata property (P791) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISILID = 791,

		/// <summary>Wikidata property (P792) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Chapter = 792,

		/// <summary>Wikidata property (P793) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SignificantEvent = 793,

		/// <summary>Wikidata property (P794) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		As = 794,

		/// <summary>Wikidata property (P795) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DistanceAlong = 795,

		/// <summary>Wikidata property (P796) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		GeoDatum = 796,

		/// <summary>Wikidata property (P797) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ExecutiveAuthority = 797,

		/// <summary>Wikidata property (P798) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MilitaryDesignation = 798,

		/// <summary>Wikidata property (P799) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AirMinistrySpecificationID = 799,

		/// <summary>Wikidata property (P800) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		NotableWork = 800,

		/// <summary>Wikidata property (P802) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Student = 802,

		/// <summary>Wikidata property (P803) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Professorship = 803,

		/// <summary>Wikidata property (P804) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GNISAntarcticaID = 804,

		/// <summary>Wikidata property (P805) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SubjectOf = 805,

		/// <summary>Wikidata property (P806) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ItalianCadastreCode = 806,

		/// <summary>Wikidata property (P807) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SeparatedFrom = 807,

		/// <summary>Wikidata property (P808) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CodeBienDeInteresCultural = 808,

		/// <summary>Wikidata property (P809) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WDPAId = 809,

		/// <summary>Wikidata property (P811) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AcademicMinor = 811,

		/// <summary>Wikidata property (P812) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AcademicMajor = 812,

		/// <summary>Wikidata property (P813) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		Retrieved = 813,

		/// <summary>Wikidata property (P814) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		IUCNProtectedAreasCategory = 814,

		/// <summary>Wikidata property (P815) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ITISTSN = 815,

		/// <summary>Wikidata property (P816) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DecaysTo = 816,

		/// <summary>Wikidata property (P817) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DecayMode = 817,

		/// <summary>Wikidata property (P818) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ArXivID = 818,

		/// <summary>Wikidata property (P819) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ADSBibcode = 819,

		/// <summary>Wikidata property (P820) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ArXivClassification = 820,

		/// <summary>Wikidata property (P821) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CGNDBUniqueIdentifier = 821,

		/// <summary>Wikidata property (P822) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Mascot = 822,

		/// <summary>Wikidata property (P823) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Speaker = 823,

		/// <summary>Wikidata property (P824) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MeteoriticalBulletinDatabaseID = 824,

		/// <summary>Wikidata property (P825) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DedicatedTo = 825,

		/// <summary>Wikidata property (P826) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Tonality = 826,

		/// <summary>Wikidata property (P827) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BBCProgramIdentifier = 827,

		/// <summary>Wikidata property (P828) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HasCause = 828,

		/// <summary>Wikidata property (P829) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OEISID = 829,

		/// <summary>Wikidata property (P830) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EncyclopediaOfLifeID = 830,

		/// <summary>Wikidata property (P831) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ParentClub = 831,

		/// <summary>Wikidata property (P832) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PublicHoliday = 832,

		/// <summary>Wikidata property (P833) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		InterchangeStation = 833,

		/// <summary>Wikidata property (P834) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TrainDepot = 834,

		/// <summary>Wikidata property (P835) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AuthorCitationZoology = 835,

		/// <summary>Wikidata property (P836) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GSSCode2011 = 836,

		/// <summary>Wikidata property (P837) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DayInYearForPeriodicOccurrence = 837,

		/// <summary>Wikidata property (P838) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BioLibID = 838,

		/// <summary>Wikidata property (P839) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IMSLPID = 839,

		/// <summary>Wikidata property (P840) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		NarrativeLocation = 840,

		/// <summary>Wikidata property (P841) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FeastDay = 841,

		/// <summary>Wikidata property (P842) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FossilworksID = 842,

		/// <summary>Wikidata property (P843) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SIRUTACode = 843,

		/// <summary>Wikidata property (P844) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UBIGEOCode = 844,

		/// <summary>Wikidata property (P845) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SaskatchewanRegisterOfHeritagePropertyIdentifier = 845,

		/// <summary>Wikidata property (P846) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GlobalBiodiversityInformationFacilityID = 846,

		/// <summary>Wikidata property (P847) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UnitedStatesNavyAircraftDesignation = 847,

		/// <summary>Wikidata property (P849) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		JapaneseMilitaryAircraftDesignation = 849,

		/// <summary>Wikidata property (P850) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WorldRegisterOfMarineSpeciesIdentifier = 850,

		/// <summary>Wikidata property (P852) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ESRBRating = 852,

		/// <summary>Wikidata property (P853) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CERORating = 853,

		/// <summary>Wikidata property (P854) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		ReferenceURL = 854,

		/// <summary>Wikidata property (P855) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		SandboxURL = 855,

		/// <summary>Wikidata property (P856) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		OfficialWebsite = 856,

		/// <summary>Wikidata property (P857) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		CNKI = 857,

		/// <summary>Wikidata property (P858) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ESPNSCRUMID = 858,

		/// <summary>Wikidata property (P859) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Sponsor = 859,

		/// <summary>Wikidata property (P860) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EArchivLiID = 860,

		/// <summary>Wikidata property (P861) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PremiershiprugbyComID = 861,

		/// <summary>Wikidata property (P862) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OperationalRequirementOfTheUKAirMinistry = 862,

		/// <summary>Wikidata property (P863) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		InPhOIdentifier = 863,

		/// <summary>Wikidata property (P864) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ACMDigitalLibraryAuthorIdentifier = 864,

		/// <summary>Wikidata property (P865) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BMLO = 865,

		/// <summary>Wikidata property (P866) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PerlentaucherID = 866,

		/// <summary>Wikidata property (P867) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ROMEOccupationCodeV3 = 867,

		/// <summary>Wikidata property (P868) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FoodsTraditionallyAssociated = 868,

		/// <summary>Wikidata property (P870) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Instrumentation = 870,

		/// <summary>Wikidata property (P872) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PrintedBy = 872,

		/// <summary>Wikidata property (P873) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PhasePoint = 873,

		/// <summary>Wikidata property (P874) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UNClass = 874,

		/// <summary>Wikidata property (P875) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UNCodeClassification = 875,

		/// <summary>Wikidata property (P876) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UNPackagingGroup = 876,

		/// <summary>Wikidata property (P877) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NFPAOther = 877,

		/// <summary>Wikidata property (P878) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Avionics = 878,

		/// <summary>Wikidata property (P879) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PennantNumber = 879,

		/// <summary>Wikidata property (P880) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CPU = 880,

		/// <summary>Wikidata property (P881) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TypeOfVariableStar = 881,

		/// <summary>Wikidata property (P882) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FIPS64USCounties = 882,

		/// <summary>Wikidata property (P883) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FIPS52CodeForUSStates = 883,

		/// <summary>Wikidata property (P884) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		StateWaterRegisterCodeRussia = 884,

		/// <summary>Wikidata property (P885) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OriginOfTheWatercourse = 885,

		/// <summary>Wikidata property (P886) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LIR = 886,

		/// <summary>Wikidata property (P887) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		BasedOnHeuristic = 887,

		/// <summary>Wikidata property (P888) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		JSTORArticleID = 888,

		/// <summary>Wikidata property (P889) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MathematicalReviewsIdentifier = 889,

		/// <summary>Wikidata property (P892) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RequestForCommentsIdentifier = 892,

		/// <summary>Wikidata property (P893) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SocialScienceResearchNetworkID = 893,

		/// <summary>Wikidata property (P894) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ZentralblattMATH = 894,

		/// <summary>Wikidata property (P897) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UnitedStatesArmyAndAirForceAircraftDesignation = 897,

		/// <summary>Wikidata property (P898) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IPA = 898,

		/// <summary>Wikidata property (P901) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FIPS104CountriesAndRegions = 901,

		/// <summary>Wikidata property (P902) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HDS = 902,

		/// <summary>Wikidata property (P905) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PORTFilmID = 905,

		/// <summary>Wikidata property (P906) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SELIBR = 906,

		/// <summary>Wikidata property (P907) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AllgameID = 907,

		/// <summary>Wikidata property (P908) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PEGIRating = 908,

		/// <summary>Wikidata property (P909) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NovaScotiaRegisterOfHistoricPlacesIdentifier = 909,

		/// <summary>Wikidata property (P910) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TopicsMainCategory = 910,

		/// <summary>Wikidata property (P911) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SouthAfricanMunicipalityCode = 911,

		/// <summary>Wikidata property (P912) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HasFacility = 912,

		/// <summary>Wikidata property (P913) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Notation = 913,

		/// <summary>Wikidata property (P914) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		USKRating = 914,

		/// <summary>Wikidata property (P915) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FilmingLocation = 915,

		/// <summary>Wikidata property (P916) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		GSRRRating = 916,

		/// <summary>Wikidata property (P917) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GRAUIndex = 917,

		/// <summary>Wikidata property (P918) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NOCOccupationCode = 918,

		/// <summary>Wikidata property (P919) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SOCOccupationCode2010 = 919,

		/// <summary>Wikidata property (P920) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SpanishSubjectHeadingsForPublicLibraries = 920,

		/// <summary>Wikidata property (P921) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MainSubject = 921,

		/// <summary>Wikidata property (P922) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MagneticOrdering = 922,

		/// <summary>Wikidata property (P923) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MedicalExaminations = 923,

		/// <summary>Wikidata property (P924) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MedicalTreatment = 924,

		/// <summary>Wikidata property (P925) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PresynapticConnection = 925,

		/// <summary>Wikidata property (P926) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PostsynapticConnection = 926,

		/// <summary>Wikidata property (P927) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AnatomicalLocation = 927,

		/// <summary>Wikidata property (P928) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ActivatingNeurotransmitter = 928,

		/// <summary>Wikidata property (P929) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ColorSpace = 929,

		/// <summary>Wikidata property (P930) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TypeOfElectrification = 930,

		/// <summary>Wikidata property (P931) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PlaceServedByAirport = 931,

		/// <summary>Wikidata property (P932) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PMCID = 932,

		/// <summary>Wikidata property (P933) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HeritagefoundationCaID = 933,

		/// <summary>Wikidata property (P935) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CommonsGallery = 935,

		/// <summary>Wikidata property (P937) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		WorkLocation = 937,

		/// <summary>Wikidata property (P938) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FishBaseSpeciesIdentifier = 938,

		/// <summary>Wikidata property (P939) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KSHCode = 939,

		/// <summary>Wikidata property (P940) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GHSPrecautionaryStatements = 940,

		/// <summary>Wikidata property (P941) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		InspiredBy = 941,

		/// <summary>Wikidata property (P942) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ThemeMusic = 942,

		/// <summary>Wikidata property (P943) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Programmer = 943,

		/// <summary>Wikidata property (P944) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CodeOfNomenclature = 944,

		/// <summary>Wikidata property (P945) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Allegiance = 945,

		/// <summary>Wikidata property (P946) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISIN = 946,

		/// <summary>Wikidata property (P947) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RSLIdentifierPerson = 947,

		/// <summary>Wikidata property (P948) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		WikivoyageBanner = 948,

		/// <summary>Wikidata property (P949) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NLIIsraelIdentifier = 949,

		/// <summary>Wikidata property (P950) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BNEIdentifier = 950,

		/// <summary>Wikidata property (P951) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NSZLIdentifier = 951,

		/// <summary>Wikidata property (P952) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISCOOccupationCode = 952,

		/// <summary>Wikidata property (P953) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		FullTextAvailableAt = 953,

		/// <summary>Wikidata property (P954) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IBNRIdentifier = 954,

		/// <summary>Wikidata property (P957) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISBN10 = 957,

		/// <summary>Wikidata property (P958) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SectionVerseOrParagraph = 958,

		/// <summary>Wikidata property (P959) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MSWIdentifier = 959,

		/// <summary>Wikidata property (P960) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TropicosTaxonNameIdentifier = 960,

		/// <summary>Wikidata property (P961) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IPNIPlantID = 961,

		/// <summary>Wikidata property (P962) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MycoBankTaxonNameIdentifier = 962,

		/// <summary>Wikidata property (P963) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		StreamingMediaURL = 963,

		/// <summary>Wikidata property (P964) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AustrianMunicipalityKey = 964,

		/// <summary>Wikidata property (P965) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BurialPlotReference = 965,

		/// <summary>Wikidata property (P966) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MusicBrainzLabelID = 966,

		/// <summary>Wikidata property (P967) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		GuestOfHonor = 967,

		/// <summary>Wikidata property (P968) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		EMail = 968,

		/// <summary>Wikidata property (P969) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LocatedAtStreetAddress = 969,

		/// <summary>Wikidata property (P970) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		NeurologicalFunction = 970,

		/// <summary>Wikidata property (P971) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CategoryCombinesTopics = 971,

		/// <summary>Wikidata property (P972) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Catalog = 972,

		/// <summary>Wikidata property (P973) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		DescribedAtURL = 973,

		/// <summary>Wikidata property (P974) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Tributary = 974,

		/// <summary>Wikidata property (P980) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CodeForWeekendAndHolidayHomesSweden = 980,

		/// <summary>Wikidata property (P981) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BAGCodeForDutchTowns = 981,

		/// <summary>Wikidata property (P982) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MusicBrainzAreaID = 982,

		/// <summary>Wikidata property (P984) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IOCCountryCode = 984,

		/// <summary>Wikidata property (P988) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PhilippineStandardGeographicCode = 988,

		/// <summary>Wikidata property (P989) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		SpokenTextAudio = 989,

		/// <summary>Wikidata property (P990) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		AudioRecordingOfTheSubjectsSpokenVoice = 990,

		/// <summary>Wikidata property (P991) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SuccessfulCandidate = 991,

		/// <summary>Wikidata property (P993) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NFPAHealth = 993,

		/// <summary>Wikidata property (P994) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NFPAFire = 994,

		/// <summary>Wikidata property (P995) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NFPAReactivity = 995,

		/// <summary>Wikidata property (P996) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		ScanFileCommons = 996,

		/// <summary>Wikidata property (P998) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Dmoz = 998,

		/// <summary>Wikidata property (P999) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ARICNS = 999,

		/// <summary>Wikidata property (P1000) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		RecordHeld = 1000,

		/// <summary>Wikidata property (P1001) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AppliesToJurisdiction = 1001,

		/// <summary>Wikidata property (P1002) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		EngineConfiguration = 1002,

		/// <summary>Wikidata property (P1003) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NLRRomaniaIdentifier = 1003,

		/// <summary>Wikidata property (P1004) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MusicBrainzPlaceID = 1004,

		/// <summary>Wikidata property (P1005) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PTBNPIdentifier = 1005,

		/// <summary>Wikidata property (P1006) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NTAIdentifierNetherlands = 1006,

		/// <summary>Wikidata property (P1007) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LattesPlatformNumber = 1007,

		/// <summary>Wikidata property (P1010) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IranStatisticsID = 1010,

		/// <summary>Wikidata property (P1011) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Excluding = 1011,

		/// <summary>Wikidata property (P1012) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Including = 1012,

		/// <summary>Wikidata property (P1013) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CriterionUsed = 1013,

		/// <summary>Wikidata property (P1014) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AATIdentifier = 1014,

		/// <summary>Wikidata property (P1015) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BIBSYSIdentifier = 1015,

		/// <summary>Wikidata property (P1016) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AsteroidTaxonomy = 1016,

		/// <summary>Wikidata property (P1017) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BAVVaticanLibraryIdentifier = 1017,

		/// <summary>Wikidata property (P1018) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LanguageRegulatoryBody = 1018,

		/// <summary>Wikidata property (P1019) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		FeedURL = 1019,

		/// <summary>Wikidata property (P1021) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KldB2010OccupationCode = 1021,

		/// <summary>Wikidata property (P1022) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CNO11OccupationCode = 1022,

		/// <summary>Wikidata property (P1023) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SBC2010OccupationCode = 1023,

		/// <summary>Wikidata property (P1024) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SBFIOccupationCode = 1024,

		/// <summary>Wikidata property (P1025) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SUDOCEditions = 1025,

		/// <summary>Wikidata property (P1026) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DoctoralThesis = 1026,

		/// <summary>Wikidata property (P1027) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ConferredBy = 1027,

		/// <summary>Wikidata property (P1028) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DonatedBy = 1028,

		/// <summary>Wikidata property (P1029) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CrewMember = 1029,

		/// <summary>Wikidata property (P1030) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LightCharacteristicOfALighthouse = 1030,

		/// <summary>Wikidata property (P1031) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LegalCitationOfThisText = 1031,

		/// <summary>Wikidata property (P1032) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DigitalRightsManagementSystem = 1032,

		/// <summary>Wikidata property (P1033) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		GHSSignalWord = 1033,

		/// <summary>Wikidata property (P1034) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MainFoodSource = 1034,

		/// <summary>Wikidata property (P1035) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HonorificSuffix = 1035,

		/// <summary>Wikidata property (P1036) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DeweyDecimalClassification = 1036,

		/// <summary>Wikidata property (P1037) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ManagerDirector = 1037,

		/// <summary>Wikidata property (P1038) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Relative = 1038,

		/// <summary>Wikidata property (P1039) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TypeOfKinship = 1039,

		/// <summary>Wikidata property (P1040) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FilmEditor = 1040,

		/// <summary>Wikidata property (P1041) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SocketsSupported = 1041,

		/// <summary>Wikidata property (P1042) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ZDBIdentifier = 1042,

		/// <summary>Wikidata property (P1043) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IDEOJobID = 1043,

		/// <summary>Wikidata property (P1044) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SWBEditions = 1044,

		/// <summary>Wikidata property (P1045) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SycomoreID = 1045,

		/// <summary>Wikidata property (P1046) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DiscoveryMethod = 1046,

		/// <summary>Wikidata property (P1047) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CatholicHierarchyPersonID = 1047,

		/// <summary>Wikidata property (P1048) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NCLIdentifier = 1048,

		/// <summary>Wikidata property (P1049) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DeityOf = 1049,

		/// <summary>Wikidata property (P1050) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MedicalCondition = 1050,

		/// <summary>Wikidata property (P1051) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PSHID = 1051,

		/// <summary>Wikidata property (P1052) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PortugueseJobCodeCPP2010 = 1052,

		/// <summary>Wikidata property (P1053) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ResearcherID = 1053,

		/// <summary>Wikidata property (P1054) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NDLEditions = 1054,

		/// <summary>Wikidata property (P1055) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NLMUniqueID = 1055,

		/// <summary>Wikidata property (P1056) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Product = 1056,

		/// <summary>Wikidata property (P1057) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Chromosome = 1057,

		/// <summary>Wikidata property (P1058) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ERAJournalID = 1058,

		/// <summary>Wikidata property (P1059) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CVR = 1059,

		/// <summary>Wikidata property (P1060) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PathogenTransmissionProcess = 1060,

		/// <summary>Wikidata property (P1064) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TrackGauge = 1064,

		/// <summary>Wikidata property (P1065) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		ArchiveURL = 1065,

		/// <summary>Wikidata property (P1066) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		StudentOf = 1066,

		/// <summary>Wikidata property (P1067) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ThailandCentralAdministrativeUnitCode = 1067,

		/// <summary>Wikidata property (P1068) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		InstructionSet = 1068,

		/// <summary>Wikidata property (P1069) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DanemarkJobCodeDISCO08 = 1069,

		/// <summary>Wikidata property (P1070) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PlantListID = 1070,

		/// <summary>Wikidata property (P1071) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LocationOfFinalAssembly = 1071,

		/// <summary>Wikidata property (P1072) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ReadableFileFormat = 1072,

		/// <summary>Wikidata property (P1073) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		WritableFileFormat = 1073,

		/// <summary>Wikidata property (P1074) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FictionalAnalogOf = 1074,

		/// <summary>Wikidata property (P1075) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Rector = 1075,

		/// <summary>Wikidata property (P1076) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ICTVVirusID = 1076,

		/// <summary>Wikidata property (P1077) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KOATUUIdentifier = 1077,

		/// <summary>Wikidata property (P1078) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ValvetrainConfiguration = 1078,

		/// <summary>Wikidata property (P1079) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LaunchContractor = 1079,

		/// <summary>Wikidata property (P1080) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FromFictionalUniverse = 1080,

		/// <summary>Wikidata property (P1081) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		HumanDevelopmentIndex = 1081,

		/// <summary>Wikidata property (P1082) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Population = 1082,

		/// <summary>Wikidata property (P1083) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MaximumCapacity = 1083,

		/// <summary>Wikidata property (P1084) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EULEditions = 1084,

		/// <summary>Wikidata property (P1085) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LibraryThingWorkIdentifier = 1085,

		/// <summary>Wikidata property (P1086) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		AtomicNumber = 1086,

		/// <summary>Wikidata property (P1087) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		EloRating = 1087,

		/// <summary>Wikidata property (P1088) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MohsHardness = 1088,

		/// <summary>Wikidata property (P1090) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Redshift = 1090,

		/// <summary>Wikidata property (P1092) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		TotalProduced = 1092,

		/// <summary>Wikidata property (P1093) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		GrossTonnage = 1093,

		/// <summary>Wikidata property (P1096) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		OrbitalEccentricity = 1096,

		/// <summary>Wikidata property (P1097) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		GFactor = 1097,

		/// <summary>Wikidata property (P1098) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfSpeakers = 1098,

		/// <summary>Wikidata property (P1099) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfMasts = 1099,

		/// <summary>Wikidata property (P1100) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfCylinders = 1100,

		/// <summary>Wikidata property (P1101) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		FloorsAboveGround = 1101,

		/// <summary>Wikidata property (P1102) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Flattening = 1102,

		/// <summary>Wikidata property (P1103) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfPlatformTracks = 1103,

		/// <summary>Wikidata property (P1104) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfPages = 1104,

		/// <summary>Wikidata property (P1106) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		SandboxQuantity = 1106,

		/// <summary>Wikidata property (P1107) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Proportion = 1107,

		/// <summary>Wikidata property (P1108) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Electronegativity = 1108,

		/// <summary>Wikidata property (P1109) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		RefractiveIndex = 1109,

		/// <summary>Wikidata property (P1110) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Attendance = 1110,

		/// <summary>Wikidata property (P1111) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		VotesReceived = 1111,

		/// <summary>Wikidata property (P1112) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		PokedexNumber = 1112,

		/// <summary>Wikidata property (P1113) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		SeriesLength = 1113,

		/// <summary>Wikidata property (P1114) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Quantity = 1114,

		/// <summary>Wikidata property (P1115) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ATVKID = 1115,

		/// <summary>Wikidata property (P1116) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ELSTATGeographicalCode = 1116,

		/// <summary>Wikidata property (P1117) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		PKa = 1117,

		/// <summary>Wikidata property (P1120) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfDeaths = 1120,

		/// <summary>Wikidata property (P1121) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		OxidationState = 1121,

		/// <summary>Wikidata property (P1122) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		SpinQuantumNumber = 1122,

		/// <summary>Wikidata property (P1123) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Parity = 1123,

		/// <summary>Wikidata property (P1124) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		TEU = 1124,

		/// <summary>Wikidata property (P1125) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		GiniCoefficient = 1125,

		/// <summary>Wikidata property (P1126) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		IsospinQuantumNumber = 1126,

		/// <summary>Wikidata property (P1127) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		IsospinZComponent = 1127,

		/// <summary>Wikidata property (P1128) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Employees = 1128,

		/// <summary>Wikidata property (P1129) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NationalTeamCaps = 1129,

		/// <summary>Wikidata property (P1132) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfParticipants = 1132,

		/// <summary>Wikidata property (P1133) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DGO4Identifier = 1133,

		/// <summary>Wikidata property (P1135) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		NomenclaturalStatus = 1135,

		/// <summary>Wikidata property (P1136) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SolvedBy = 1136,

		/// <summary>Wikidata property (P1137) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FossilFoundInThisUnit = 1137,

		/// <summary>Wikidata property (P1138) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KunstindeksDanmarkArtistID = 1138,

		/// <summary>Wikidata property (P1139) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		FloorsBelowGround = 1139,

		/// <summary>Wikidata property (P1140) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EHAKId = 1140,

		/// <summary>Wikidata property (P1141) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfProcessorCores = 1141,

		/// <summary>Wikidata property (P1142) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PoliticalIdeology = 1142,

		/// <summary>Wikidata property (P1143) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BNArgentineEditions = 1143,

		/// <summary>Wikidata property (P1144) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LCOCLCCNBibliographic = 1144,

		/// <summary>Wikidata property (P1145) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LagrangianPoint = 1145,

		/// <summary>Wikidata property (P1146) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IAAFID = 1146,

		/// <summary>Wikidata property (P1148) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NeutronNumber = 1148,

		/// <summary>Wikidata property (P1149) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LibraryOfCongressClassification = 1149,

		/// <summary>Wikidata property (P1150) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RegensburgClassification = 1150,

		/// <summary>Wikidata property (P1151) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TopicsMainWikimediaPortal = 1151,

		/// <summary>Wikidata property (P1152) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		IPTCMediaTopic = 1152,

		/// <summary>Wikidata property (P1153) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ScopusAuthorID = 1153,

		/// <summary>Wikidata property (P1154) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ScopusEID = 1154,

		/// <summary>Wikidata property (P1155) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ScopusAffiliationID = 1155,

		/// <summary>Wikidata property (P1156) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ScopusSourceID = 1156,

		/// <summary>Wikidata property (P1157) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		USCongressBioIdentifier = 1157,

		/// <summary>Wikidata property (P1158) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LocationOfLanding = 1158,

		/// <summary>Wikidata property (P1159) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CODEN = 1159,

		/// <summary>Wikidata property (P1160) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISO4Abbreviation = 1160,

		/// <summary>Wikidata property (P1161) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Z395Abbreviation = 1161,

		/// <summary>Wikidata property (P1162) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BluebookAbbreviation = 1162,

		/// <summary>Wikidata property (P1163) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		InternetMediaType = 1163,

		/// <summary>Wikidata property (P1164) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		CardinalityOfTheGroup = 1164,

		/// <summary>Wikidata property (P1165) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HomeWorld = 1165,

		/// <summary>Wikidata property (P1167) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		USBID = 1167,

		/// <summary>Wikidata property (P1168) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MunicipalityCodeDenmark = 1168,

		/// <summary>Wikidata property (P1170) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TransmittedSignal = 1170,

		/// <summary>Wikidata property (P1171) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ApproximationAlgorithm = 1171,

		/// <summary>Wikidata property (P1172) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Geokod = 1172,

		/// <summary>Wikidata property (P1174) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		VisitorsPerYear = 1174,

		/// <summary>Wikidata property (P1181) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumericValue = 1181,

		/// <summary>Wikidata property (P1182) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LIBRISEditions = 1182,

		/// <summary>Wikidata property (P1183) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Gewässerkennzahl = 1183,

		/// <summary>Wikidata property (P1184) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Handle = 1184,

		/// <summary>Wikidata property (P1185) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RodovidID = 1185,

		/// <summary>Wikidata property (P1186) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MEPDirectoryIdentifier = 1186,

		/// <summary>Wikidata property (P1187) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DharmaDrumBuddhistCollegePersonID = 1187,

		/// <summary>Wikidata property (P1188) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DharmaDrumBuddhistCollegePlaceID = 1188,

		/// <summary>Wikidata property (P1189) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ChineseLibraryClassification = 1189,

		/// <summary>Wikidata property (P1190) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UniversalDecimalClassification = 1190,

		/// <summary>Wikidata property (P1191) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		FirstPerformance = 1191,

		/// <summary>Wikidata property (P1192) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ConnectingService = 1192,

		/// <summary>Wikidata property (P1193) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Prevalence = 1193,

		/// <summary>Wikidata property (P1194) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ReceivedSignal = 1194,

		/// <summary>Wikidata property (P1195) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FileExtension = 1195,

		/// <summary>Wikidata property (P1196) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MannerOfDeath = 1196,

		/// <summary>Wikidata property (P1198) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		UnemploymentRate = 1198,

		/// <summary>Wikidata property (P1199) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ModeOfInheritance = 1199,

		/// <summary>Wikidata property (P1200) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		BodiesOfWaterBasinCategory = 1200,

		/// <summary>Wikidata property (P1201) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SpaceTug = 1201,

		/// <summary>Wikidata property (P1202) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CarriesScientificInstrument = 1202,

		/// <summary>Wikidata property (P1203) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FinnishMunicipalityNumber = 1203,

		/// <summary>Wikidata property (P1204) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		WikimediaPortalsMainTopic = 1204,

		/// <summary>Wikidata property (P1207) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NUKATWarsawUAuthorities = 1207,

		/// <summary>Wikidata property (P1208) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISMN = 1208,

		/// <summary>Wikidata property (P1209) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CN = 1209,

		/// <summary>Wikidata property (P1210) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Supercharger = 1210,

		/// <summary>Wikidata property (P1211) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FuelSystem = 1211,

		/// <summary>Wikidata property (P1212) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AtlasID = 1212,

		/// <summary>Wikidata property (P1213) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NLCAuthorities = 1213,

		/// <summary>Wikidata property (P1214) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RiksdagenPersonId = 1214,

		/// <summary>Wikidata property (P1215) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		ApparentMagnitude = 1215,

		/// <summary>Wikidata property (P1216) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NationalHeritageListForEnglandNumber = 1216,

		/// <summary>Wikidata property (P1217) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		InternetBroadwayDatabaseVenueID = 1217,

		/// <summary>Wikidata property (P1218) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		InternetBroadwayDatabaseProductionID = 1218,

		/// <summary>Wikidata property (P1219) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		InternetBroadwayDatabaseShowID = 1219,

		/// <summary>Wikidata property (P1220) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		InternetBroadwayDatabasePersonID = 1220,

		/// <summary>Wikidata property (P1221) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CompressorType = 1221,

		/// <summary>Wikidata property (P1222) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NARAPersonID = 1222,

		/// <summary>Wikidata property (P1223) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NARAOrganizationID = 1223,

		/// <summary>Wikidata property (P1224) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NARAGeographicID = 1224,

		/// <summary>Wikidata property (P1225) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NARATopicalSubjectID = 1225,

		/// <summary>Wikidata property (P1226) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NARASpecificRecordsTypeID = 1226,

		/// <summary>Wikidata property (P1227) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AstronomicalFilter = 1227,

		/// <summary>Wikidata property (P1229) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OpenpolisID = 1229,

		/// <summary>Wikidata property (P1230) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		JSTORJournalCode = 1230,

		/// <summary>Wikidata property (P1231) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NARACatalogRecordID = 1231,

		/// <summary>Wikidata property (P1232) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LinguistListCode = 1232,

		/// <summary>Wikidata property (P1233) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISFDBAuthorID = 1233,

		/// <summary>Wikidata property (P1234) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISFDBPublicationID = 1234,

		/// <summary>Wikidata property (P1235) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISFDBSeriesID = 1235,

		/// <summary>Wikidata property (P1236) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ParsonsCode = 1236,

		/// <summary>Wikidata property (P1237) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BoxOfficeMojoFilmID = 1237,

		/// <summary>Wikidata property (P1238) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SwedishFootballAssociationID = 1238,

		/// <summary>Wikidata property (P1239) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISFDBPublisherID = 1239,

		/// <summary>Wikidata property (P1240) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DanishBibliometricResearchIndicatorLevel = 1240,

		/// <summary>Wikidata property (P1241) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SwissFootballAssociationClubNumber = 1241,

		/// <summary>Wikidata property (P1242) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TheatricaliaPlayID = 1242,

		/// <summary>Wikidata property (P1243) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		InternationalStandardRecordingCode = 1243,

		/// <summary>Wikidata property (P1244) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		PhoneNumberURL = 1244,

		/// <summary>Wikidata property (P1245) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OmegaWikiDefinedMeaning = 1245,

		/// <summary>Wikidata property (P1246) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PatentNumber = 1246,

		/// <summary>Wikidata property (P1247) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		CompressionRatio = 1247,

		/// <summary>Wikidata property (P1248) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KulturNavId = 1248,

		/// <summary>Wikidata property (P1249) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		TimeOfEarliestWrittenRecord = 1249,

		/// <summary>Wikidata property (P1250) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DanishBibliometricResearchIndicatorBFISNOCNO = 1250,

		/// <summary>Wikidata property (P1251) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ABSASCLCode = 1251,

		/// <summary>Wikidata property (P1252) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AUSTLANGCode = 1252,

		/// <summary>Wikidata property (P1253) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BCUEcrivainsvd = 1253,

		/// <summary>Wikidata property (P1254) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SlovenskaBiografijaID = 1254,

		/// <summary>Wikidata property (P1255) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HelveticarchivesID = 1255,

		/// <summary>Wikidata property (P1256) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IconclassNotation = 1256,

		/// <summary>Wikidata property (P1257) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DepictsIconclassNotation = 1257,

		/// <summary>Wikidata property (P1258) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RottenTomatoesIdentifier = 1258,

		/// <summary>Wikidata property (P1259) of <see cref="DataType.GlobeCoordinate"/></summary>
		[Type(DataType.GlobeCoordinate)]
		CoordinatesOfThePointOfView = 1259,

		/// <summary>Wikidata property (P1260) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CulturalHeritageDatabaseInSweden = 1260,

		/// <summary>Wikidata property (P1261) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Rundata = 1261,

		/// <summary>Wikidata property (P1262) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RAÄNummer = 1262,

		/// <summary>Wikidata property (P1263) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NNDBPeopleID = 1263,

		/// <summary>Wikidata property (P1264) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ValidInPeriod = 1264,

		/// <summary>Wikidata property (P1265) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AlloCineMovieID = 1265,

		/// <summary>Wikidata property (P1266) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AlloCinePersonID = 1266,

		/// <summary>Wikidata property (P1267) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AlloCineSeriesID = 1267,

		/// <summary>Wikidata property (P1268) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		RepresentsOrganisation = 1268,

		/// <summary>Wikidata property (P1269) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FacetOf = 1269,

		/// <summary>Wikidata property (P1270) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NorwayDatabaseForStatisticsOnHigherEducationPeriodicalID = 1270,

		/// <summary>Wikidata property (P1271) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NorwayDatabaseForStatisticsOnHigherEducationPublisherID = 1271,

		/// <summary>Wikidata property (P1272) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NorwayImportServiceAndRegistrationAuthorityPeriodicalCode = 1272,

		/// <summary>Wikidata property (P1273) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CANTIC = 1273,

		/// <summary>Wikidata property (P1274) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISFDBTitleID = 1274,

		/// <summary>Wikidata property (P1275) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NorwayImportServiceAndRegistrationAuthorityPublisherCode = 1275,

		/// <summary>Wikidata property (P1276) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DictionnaireDuJuraID = 1276,

		/// <summary>Wikidata property (P1277) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		JufoID = 1277,

		/// <summary>Wikidata property (P1278) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LegalEntityIdentifier = 1278,

		/// <summary>Wikidata property (P1279) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		InflationRate = 1279,

		/// <summary>Wikidata property (P1280) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CONORIdentifier = 1280,

		/// <summary>Wikidata property (P1281) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WOEID = 1281,

		/// <summary>Wikidata property (P1282) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OpenStreetMapTagOrKey = 1282,

		/// <summary>Wikidata property (P1283) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Filmography = 1283,

		/// <summary>Wikidata property (P1284) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MunzingerIBA = 1284,

		/// <summary>Wikidata property (P1285) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MunzingerSport = 1285,

		/// <summary>Wikidata property (P1286) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MunzingerPopIdentifier = 1286,

		/// <summary>Wikidata property (P1287) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KDGKomponistenDerGegenwart = 1287,

		/// <summary>Wikidata property (P1288) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KLGKritischesLexikonDerGegenwartsliteratur = 1288,

		/// <summary>Wikidata property (P1289) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KLfGKritischesLexikonDerFremdsprachigenGegenwartsliteratur = 1289,

		/// <summary>Wikidata property (P1290) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Godparent = 1290,

		/// <summary>Wikidata property (P1291) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AssociationAuthorsOfSwitzerlandID = 1291,

		/// <summary>Wikidata property (P1292) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DNBEditions = 1292,

		/// <summary>Wikidata property (P1293) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RoyalAeroClubAviatorsCertificateID = 1293,

		/// <summary>Wikidata property (P1294) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WWFEcoregionCode = 1294,

		/// <summary>Wikidata property (P1295) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Emissivity = 1295,

		/// <summary>Wikidata property (P1296) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GranEnciclopèdiaCatalanaID = 1296,

		/// <summary>Wikidata property (P1297) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IRSEmployerIdentificationNumber = 1297,

		/// <summary>Wikidata property (P1299) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DepictedBy = 1299,

		/// <summary>Wikidata property (P1300) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Bibcode = 1300,

		/// <summary>Wikidata property (P1301) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfElevators = 1301,

		/// <summary>Wikidata property (P1302) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PrimaryDestinations = 1302,

		/// <summary>Wikidata property (P1303) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Instrument = 1303,

		/// <summary>Wikidata property (P1304) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CentralBank = 1304,

		/// <summary>Wikidata property (P1305) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SkyscraperCenterID = 1305,

		/// <summary>Wikidata property (P1307) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SwissParliamentIdentifier = 1307,

		/// <summary>Wikidata property (P1308) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Officeholder = 1308,

		/// <summary>Wikidata property (P1309) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EGAXAIdentifier = 1309,

		/// <summary>Wikidata property (P1310) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		StatementDisputedBy = 1310,

		/// <summary>Wikidata property (P1311) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LostbridgesOrgID = 1311,

		/// <summary>Wikidata property (P1312) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HasFacetPolytope = 1312,

		/// <summary>Wikidata property (P1313) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OfficeHeldByHeadOfGovernment = 1313,

		/// <summary>Wikidata property (P1314) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfSpans = 1314,

		/// <summary>Wikidata property (P1315) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PeopleAustraliaIdentifier = 1315,

		/// <summary>Wikidata property (P1316) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SMDBID = 1316,

		/// <summary>Wikidata property (P1317) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		Floruit = 1317,

		/// <summary>Wikidata property (P1318) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ProvedBy = 1318,

		/// <summary>Wikidata property (P1319) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		EarliestDate = 1319,

		/// <summary>Wikidata property (P1320) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OpenCorporatesID = 1320,

		/// <summary>Wikidata property (P1321) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PlaceOfOriginSwitzerland = 1321,

		/// <summary>Wikidata property (P1322) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DualTo = 1322,

		/// <summary>Wikidata property (P1323) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TerminologiaAnatomica98 = 1323,

		/// <summary>Wikidata property (P1324) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		SourceCodeRepository = 1324,

		/// <summary>Wikidata property (P1325) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		ExternalDataAvailableAt = 1325,

		/// <summary>Wikidata property (P1326) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		LatestDate = 1326,

		/// <summary>Wikidata property (P1327) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ProfessionalOrSportsPartner = 1327,

		/// <summary>Wikidata property (P1329) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PhoneNumber = 1329,

		/// <summary>Wikidata property (P1330) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MusicBrainzInstrumentID = 1330,

		/// <summary>Wikidata property (P1331) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PACEMemberID = 1331,

		/// <summary>Wikidata property (P1332) of <see cref="DataType.GlobeCoordinate"/></summary>
		[Type(DataType.GlobeCoordinate)]
		CoordinateOfNorthernmostPoint = 1332,

		/// <summary>Wikidata property (P1333) of <see cref="DataType.GlobeCoordinate"/></summary>
		[Type(DataType.GlobeCoordinate)]
		CoordinateOfSouthernmostPoint = 1333,

		/// <summary>Wikidata property (P1334) of <see cref="DataType.GlobeCoordinate"/></summary>
		[Type(DataType.GlobeCoordinate)]
		CoordinateOfEasternmostPoint = 1334,

		/// <summary>Wikidata property (P1335) of <see cref="DataType.GlobeCoordinate"/></summary>
		[Type(DataType.GlobeCoordinate)]
		CoordinateOfWesternmostPoint = 1335,

		/// <summary>Wikidata property (P1336) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TerritoryClaimedBy = 1336,

		/// <summary>Wikidata property (P1338) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EPSGID = 1338,

		/// <summary>Wikidata property (P1339) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfInjured = 1339,

		/// <summary>Wikidata property (P1340) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		EyeColor = 1340,

		/// <summary>Wikidata property (P1341) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ItalianChamberOfDeputiesID = 1341,

		/// <summary>Wikidata property (P1342) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfSeats = 1342,

		/// <summary>Wikidata property (P1343) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DescribedBySource = 1343,

		/// <summary>Wikidata property (P1344) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ParticipantOf = 1344,

		/// <summary>Wikidata property (P1345) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfVictims = 1345,

		/// <summary>Wikidata property (P1346) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Winner = 1346,

		/// <summary>Wikidata property (P1347) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MilitaryCasualtyClassification = 1347,

		/// <summary>Wikidata property (P1348) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		AlgaeBaseURL = 1348,

		/// <summary>Wikidata property (P1349) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Ploidy = 1349,

		/// <summary>Wikidata property (P1350) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfMatchesPlayed = 1350,

		/// <summary>Wikidata property (P1351) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfPointsGoalsScored = 1351,

		/// <summary>Wikidata property (P1352) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Ranking = 1352,

		/// <summary>Wikidata property (P1353) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OriginalSpelling = 1353,

		/// <summary>Wikidata property (P1354) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ShownWithFeatures = 1354,

		/// <summary>Wikidata property (P1355) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Wins = 1355,

		/// <summary>Wikidata property (P1356) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Losses = 1356,

		/// <summary>Wikidata property (P1357) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MatchesGamesDrawnTied = 1357,

		/// <summary>Wikidata property (P1358) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		PointsFor = 1358,

		/// <summary>Wikidata property (P1359) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfPointsGoalsConceded = 1359,

		/// <summary>Wikidata property (P1360) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MonteCarloParticleNumber = 1360,

		/// <summary>Wikidata property (P1362) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TheaterlexikonDerSchweizOnlineID = 1362,

		/// <summary>Wikidata property (P1363) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PointsGoalScoredBy = 1363,

		/// <summary>Wikidata property (P1364) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ITTFID = 1364,

		/// <summary>Wikidata property (P1365) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Replaces = 1365,

		/// <summary>Wikidata property (P1366) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ReplacedBy = 1366,

		/// <summary>Wikidata property (P1367) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BBCYourPaintingsArtistIdentifier = 1367,

		/// <summary>Wikidata property (P1368) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LNBIdentifier = 1368,

		/// <summary>Wikidata property (P1369) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IranianNationalHeritageRegistrationNumber = 1369,

		/// <summary>Wikidata property (P1370) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IHSIID = 1370,

		/// <summary>Wikidata property (P1371) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ASIMonumentID = 1371,

		/// <summary>Wikidata property (P1372) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		BindingOfSoftwareLibrary = 1372,

		/// <summary>Wikidata property (P1373) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		DailyRidership = 1373,

		/// <summary>Wikidata property (P1375) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NSKIdentifier = 1375,

		/// <summary>Wikidata property (P1376) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CapitalOf = 1376,

		/// <summary>Wikidata property (P1377) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MTRStationCode = 1377,

		/// <summary>Wikidata property (P1378) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ChinaRailwayTMISStationCode = 1378,

		/// <summary>Wikidata property (P1380) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UglybridgesComID = 1380,

		/// <summary>Wikidata property (P1381) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BridgehunterComID = 1381,

		/// <summary>Wikidata property (P1382) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CoincidentWith = 1382,

		/// <summary>Wikidata property (P1383) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ContainsSettlement = 1383,

		/// <summary>Wikidata property (P1385) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EnciclopediaAçorianaID = 1385,

		/// <summary>Wikidata property (P1386) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		JapaneseHighSchoolCode = 1386,

		/// <summary>Wikidata property (P1387) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PoliticalAlignment = 1387,

		/// <summary>Wikidata property (P1388) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GermanRegionalKey = 1388,

		/// <summary>Wikidata property (P1389) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ProductCertification = 1389,

		/// <summary>Wikidata property (P1390) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MatchTimeOfScoreMinutes = 1390,

		/// <summary>Wikidata property (P1391) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IndexFungorumID = 1391,

		/// <summary>Wikidata property (P1392) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ComicBookDBID = 1392,

		/// <summary>Wikidata property (P1393) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Proxy = 1393,

		/// <summary>Wikidata property (P1394) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GlottologCode = 1394,

		/// <summary>Wikidata property (P1395) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NationalCancerInstituteID = 1395,

		/// <summary>Wikidata property (P1396) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LinguasphereCode = 1396,

		/// <summary>Wikidata property (P1397) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		StateCatalogueOfGeographicalNamesIdentifierRussia = 1397,

		/// <summary>Wikidata property (P1398) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		StructureReplaces = 1398,

		/// <summary>Wikidata property (P1399) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ConvictedOf = 1399,

		/// <summary>Wikidata property (P1400) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FCCFacilityID = 1400,

		/// <summary>Wikidata property (P1401) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		BugTrackingSystem = 1401,

		/// <summary>Wikidata property (P1402) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FoundationalModelOfAnatomyID = 1402,

		/// <summary>Wikidata property (P1403) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OriginalCombination = 1403,

		/// <summary>Wikidata property (P1404) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WorldGlacierInventoryID = 1404,

		/// <summary>Wikidata property (P1406) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ScriptDirectionality = 1406,

		/// <summary>Wikidata property (P1407) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MusicBrainzSeriesID = 1407,

		/// <summary>Wikidata property (P1408) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LicensedToBroadcastTo = 1408,

		/// <summary>Wikidata property (P1409) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CyclingArchivesCyclistID = 1409,

		/// <summary>Wikidata property (P1410) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfSeatsOfTheOrganizationInLegislature = 1410,

		/// <summary>Wikidata property (P1411) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		NominatedFor = 1411,

		/// <summary>Wikidata property (P1412) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LanguagesSpokenOrWritten = 1412,

		/// <summary>Wikidata property (P1413) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SFDbIDOBSOLETE = 1413,

		/// <summary>Wikidata property (P1414) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		GUIToolkitOrFramework = 1414,

		/// <summary>Wikidata property (P1415) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OxfordBiographyIndexNumber = 1415,

		/// <summary>Wikidata property (P1416) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Affiliation = 1416,

		/// <summary>Wikidata property (P1417) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EncyclopædiaBritannicaOnlineID = 1417,

		/// <summary>Wikidata property (P1418) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		OrbitsCompleted = 1418,

		/// <summary>Wikidata property (P1419) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Shape = 1419,

		/// <summary>Wikidata property (P1420) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TaxonSynonym = 1420,

		/// <summary>Wikidata property (P1421) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		GRINURL = 1421,

		/// <summary>Wikidata property (P1422) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SandrartNetPersonID = 1422,

		/// <summary>Wikidata property (P1423) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TemplatesMainTopic = 1423,

		/// <summary>Wikidata property (P1424) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TopicsMainTemplate = 1424,

		/// <summary>Wikidata property (P1425) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		EcoregionWWF = 1425,

		/// <summary>Wikidata property (P1427) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		JourneyOrigin = 1427,

		/// <summary>Wikidata property (P1428) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LostArtID = 1428,

		/// <summary>Wikidata property (P1429) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Pet = 1429,

		/// <summary>Wikidata property (P1430) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OpenPlaquesSubjectIdentifier = 1430,

		/// <summary>Wikidata property (P1431) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ExecutiveProducer = 1431,

		/// <summary>Wikidata property (P1432) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		BSide = 1432,

		/// <summary>Wikidata property (P1433) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PublishedIn = 1433,

		/// <summary>Wikidata property (P1434) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DescribesTheFictionalUniverse = 1434,

		/// <summary>Wikidata property (P1435) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HeritageStatus = 1435,

		/// <summary>Wikidata property (P1436) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		CollectionOrExhibitionSize = 1436,

		/// <summary>Wikidata property (P1437) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Plea = 1437,

		/// <summary>Wikidata property (P1438) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		JewishEncyclopediaIDRussian = 1438,

		/// <summary>Wikidata property (P1439) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NorskFilmografiID = 1439,

		/// <summary>Wikidata property (P1440) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FideID = 1440,

		/// <summary>Wikidata property (P1441) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PresentInWork = 1441,

		/// <summary>Wikidata property (P1442) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		ImageOfGrave = 1442,

		/// <summary>Wikidata property (P1443) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ScoreMethod = 1443,

		/// <summary>Wikidata property (P1444) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		JourneyDestination = 1444,

		/// <summary>Wikidata property (P1445) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FictionalUniverseDescribedIn = 1445,

		/// <summary>Wikidata property (P1446) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfMissing = 1446,

		/// <summary>Wikidata property (P1447) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SportsReferenceID = 1447,

		/// <summary>Wikidata property (P1448) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		OfficialName = 1448,

		/// <summary>Wikidata property (P1449) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		Nickname = 1449,

		/// <summary>Wikidata property (P1450) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		SandboxMonolingualText = 1450,

		/// <summary>Wikidata property (P1451) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		MottoText = 1451,

		/// <summary>Wikidata property (P1453) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CatholicRuIdentifier = 1453,

		/// <summary>Wikidata property (P1454) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LegalForm = 1454,

		/// <summary>Wikidata property (P1455) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ListOfWorks = 1455,

		/// <summary>Wikidata property (P1456) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ListOfMonuments = 1456,

		/// <summary>Wikidata property (P1457) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		AbsoluteMagnitude = 1457,

		/// <summary>Wikidata property (P1458) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		ColorIndex = 1458,

		/// <summary>Wikidata property (P1459) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CadwBuildingID = 1459,

		/// <summary>Wikidata property (P1460) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NIEABuildingID = 1460,

		/// <summary>Wikidata property (P1461) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PatientplusID = 1461,

		/// <summary>Wikidata property (P1462) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		StandardsBody = 1462,

		/// <summary>Wikidata property (P1463) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PRDLAuthorID = 1463,

		/// <summary>Wikidata property (P1464) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CategoryForPeopleBornHere = 1464,

		/// <summary>Wikidata property (P1465) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CategoryForPeopleWhoDiedHere = 1465,

		/// <summary>Wikidata property (P1466) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WALSLectCode = 1466,

		/// <summary>Wikidata property (P1467) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WALSGenusCode = 1467,

		/// <summary>Wikidata property (P1468) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WALSFamilyCode = 1468,

		/// <summary>Wikidata property (P1469) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FIFAPlayerCode = 1469,

		/// <summary>Wikidata property (P1470) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MaximumGlideRatio = 1470,

		/// <summary>Wikidata property (P1471) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ReportingMark = 1471,

		/// <summary>Wikidata property (P1472) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CommonsCreatorPage = 1472,

		/// <summary>Wikidata property (P1473) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NupillLiteraturaDigitalAuthor = 1473,

		/// <summary>Wikidata property (P1474) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NupillLiteraturaDigitalDocument = 1474,

		/// <summary>Wikidata property (P1476) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		Title = 1476,

		/// <summary>Wikidata property (P1477) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		BirthName = 1477,

		/// <summary>Wikidata property (P1478) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HasImmediateCause = 1478,

		/// <summary>Wikidata property (P1479) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HasContributingFactor = 1479,

		/// <summary>Wikidata property (P1480) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SourcingCircumstances = 1480,

		/// <summary>Wikidata property (P1481) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ViciOrgID = 1481,

		/// <summary>Wikidata property (P1482) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		StackExchangeTag = 1482,

		/// <summary>Wikidata property (P1483) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KulturnoeNasledieRuID = 1483,

		/// <summary>Wikidata property (P1529) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GladIdentifier = 1529,

		/// <summary>Wikidata property (P1531) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ParentSOfThisHybrid = 1531,

		/// <summary>Wikidata property (P1532) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CountryForSport = 1532,

		/// <summary>Wikidata property (P1533) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FamilyNameIdenticalToThisFirstName = 1533,

		/// <summary>Wikidata property (P1534) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		EndCause = 1534,

		/// <summary>Wikidata property (P1535) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		UsedBy = 1535,

		/// <summary>Wikidata property (P1536) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ImmediateCauseOf = 1536,

		/// <summary>Wikidata property (P1537) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ContributingFactorOf = 1537,

		/// <summary>Wikidata property (P1538) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfHouseholds = 1538,

		/// <summary>Wikidata property (P1539) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		FemalePopulation = 1539,

		/// <summary>Wikidata property (P1540) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MalePopulation = 1540,

		/// <summary>Wikidata property (P1541) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CyclingQuotientIdentifier = 1541,

		/// <summary>Wikidata property (P1542) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CauseOf = 1542,

		/// <summary>Wikidata property (P1543) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		Monogram = 1543,

		/// <summary>Wikidata property (P1544) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FederalRegisterDocumentNumber = 1544,

		/// <summary>Wikidata property (P1545) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SeriesOrdinal = 1545,

		/// <summary>Wikidata property (P1546) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Motto = 1546,

		/// <summary>Wikidata property (P1547) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DependsOn = 1547,

		/// <summary>Wikidata property (P1548) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MaximumStrahlerNumber = 1548,

		/// <summary>Wikidata property (P1549) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		Demonym = 1549,

		/// <summary>Wikidata property (P1550) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OrphanetID = 1550,

		/// <summary>Wikidata property (P1551) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ExceptionalHeritageOfWalloniaIdentifier = 1551,

		/// <summary>Wikidata property (P1552) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HasQuality = 1552,

		/// <summary>Wikidata property (P1553) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		YandexMusicID = 1553,

		/// <summary>Wikidata property (P1554) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UBERONID = 1554,

		/// <summary>Wikidata property (P1555) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ExecutiveOrderNumber = 1555,

		/// <summary>Wikidata property (P1556) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AuthorID = 1556,

		/// <summary>Wikidata property (P1557) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ManifestationOf = 1557,

		/// <summary>Wikidata property (P1558) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TempoMarking = 1558,

		/// <summary>Wikidata property (P1559) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		NameInNativeLanguage = 1559,

		/// <summary>Wikidata property (P1560) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		GivenNameVersionForOtherGender = 1560,

		/// <summary>Wikidata property (P1561) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfSurvivors = 1561,

		/// <summary>Wikidata property (P1562) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AllMovieMovieID = 1562,

		/// <summary>Wikidata property (P1563) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MacTutorIdBiographies = 1563,

		/// <summary>Wikidata property (P1564) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AtTheCirculatingLibraryID = 1564,

		/// <summary>Wikidata property (P1565) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EnciclopediaDeLaLiteraturaEnMexicoID = 1565,

		/// <summary>Wikidata property (P1566) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GeoNamesID = 1566,

		/// <summary>Wikidata property (P1567) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NISINSCode = 1567,

		/// <summary>Wikidata property (P1568) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Domain = 1568,

		/// <summary>Wikidata property (P1569) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfEdges = 1569,

		/// <summary>Wikidata property (P1570) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfVertices = 1570,

		/// <summary>Wikidata property (P1571) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Codomain = 1571,

		/// <summary>Wikidata property (P1573) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BBCGenomeIdentifier = 1573,

		/// <summary>Wikidata property (P1574) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ExemplarOf = 1574,

		/// <summary>Wikidata property (P1575) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RISSCatalog = 1575,

		/// <summary>Wikidata property (P1576) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Lifestyle = 1576,

		/// <summary>Wikidata property (P1577) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GregoryAlandNumber = 1577,

		/// <summary>Wikidata property (P1578) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GmelinNumber = 1578,

		/// <summary>Wikidata property (P1579) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BeilsteinRegistryNumber = 1579,

		/// <summary>Wikidata property (P1580) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UniversityOfBarcelonaAuthorityID = 1580,

		/// <summary>Wikidata property (P1581) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		OfficialBlog = 1581,

		/// <summary>Wikidata property (P1582) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		NaturalProductOfTaxon = 1582,

		/// <summary>Wikidata property (P1583) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MalaCardsID = 1583,

		/// <summary>Wikidata property (P1584) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PleiadesIdentifier = 1584,

		/// <summary>Wikidata property (P1585) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BrazilianMunicipalityCode = 1585,

		/// <summary>Wikidata property (P1586) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CatalanObjectOfCulturalInterestID = 1586,

		/// <summary>Wikidata property (P1587) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SloveneCulturalHeritageRegisterID = 1587,

		/// <summary>Wikidata property (P1588) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DesaCodeOfIndonesia = 1588,

		/// <summary>Wikidata property (P1589) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DeepestPoint = 1589,

		/// <summary>Wikidata property (P1590) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfCasualties = 1590,

		/// <summary>Wikidata property (P1591) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Defendant = 1591,

		/// <summary>Wikidata property (P1592) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Prosecutor = 1592,

		/// <summary>Wikidata property (P1593) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Defender = 1593,

		/// <summary>Wikidata property (P1594) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Judge = 1594,

		/// <summary>Wikidata property (P1595) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Charge = 1595,

		/// <summary>Wikidata property (P1596) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Penalty = 1596,

		/// <summary>Wikidata property (P1598) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Consecrator = 1598,

		/// <summary>Wikidata property (P1599) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CambridgeAlumniDatabaseID = 1599,

		/// <summary>Wikidata property (P1600) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CodeInventariDelPatrimoniArquitectonicDeCatalunya = 1600,

		/// <summary>Wikidata property (P1601) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EsperantistID = 1601,

		/// <summary>Wikidata property (P1602) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BBCYourPaintingsVenueIdentifier = 1602,

		/// <summary>Wikidata property (P1603) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfCases = 1603,

		/// <summary>Wikidata property (P1604) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		BiosafetyLevel = 1604,

		/// <summary>Wikidata property (P1605) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HasNaturalReservoir = 1605,

		/// <summary>Wikidata property (P1606) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		NaturalReservoirOf = 1606,

		/// <summary>Wikidata property (P1607) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DialnetAuthorID = 1607,

		/// <summary>Wikidata property (P1608) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DialnetBook = 1608,

		/// <summary>Wikidata property (P1609) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DialnetJournal = 1609,

		/// <summary>Wikidata property (P1610) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DialnetArticle = 1610,

		/// <summary>Wikidata property (P1611) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		NATOCodeForGrade = 1611,

		/// <summary>Wikidata property (P1612) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CommonsInstitutionPage = 1612,

		/// <summary>Wikidata property (P1613) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		IRCChannel = 1613,

		/// <summary>Wikidata property (P1614) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HistoryOfParliamentID = 1614,

		/// <summary>Wikidata property (P1615) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CLARAID = 1615,

		/// <summary>Wikidata property (P1616) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SIRENNumber = 1616,

		/// <summary>Wikidata property (P1617) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BBCThingsIdentifer = 1617,

		/// <summary>Wikidata property (P1618) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SportNumber = 1618,

		/// <summary>Wikidata property (P1619) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		DateOfOfficialOpening = 1619,

		/// <summary>Wikidata property (P1620) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Plaintiff = 1620,

		/// <summary>Wikidata property (P1621) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		DetailMap = 1621,

		/// <summary>Wikidata property (P1622) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DrivesOnThe = 1622,

		/// <summary>Wikidata property (P1624) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MarineTrafficPortID = 1624,

		/// <summary>Wikidata property (P1625) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HasMelody = 1625,

		/// <summary>Wikidata property (P1626) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ThaiCulturalHeritageID = 1626,

		/// <summary>Wikidata property (P1627) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EthnologueComCode = 1627,

		/// <summary>Wikidata property (P1628) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		EquivalentProperty = 1628,

		/// <summary>Wikidata property (P1629) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SubjectItemOfThisProperty = 1629,

		/// <summary>Wikidata property (P1630) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FormatterURL = 1630,

		/// <summary>Wikidata property (P1631) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ChinaVitaeID = 1631,

		/// <summary>Wikidata property (P1632) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HermannMauguinNotation = 1632,

		/// <summary>Wikidata property (P1635) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		ReligiousName = 1635,

		/// <summary>Wikidata property (P1636) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		DateOfBaptismInEarlyChildhood = 1636,

		/// <summary>Wikidata property (P1637) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Undercarriage = 1637,

		/// <summary>Wikidata property (P1638) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		WorkingTitle = 1638,

		/// <summary>Wikidata property (P1639) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PendantOf = 1639,

		/// <summary>Wikidata property (P1640) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Curator = 1640,

		/// <summary>Wikidata property (P1641) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Port = 1641,

		/// <summary>Wikidata property (P1642) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AcquisitionTransaction = 1642,

		/// <summary>Wikidata property (P1643) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DepartureTransaction = 1643,

		/// <summary>Wikidata property (P1644) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EgliseInfoID = 1644,

		/// <summary>Wikidata property (P1645) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NISTCODATAID = 1645,

		/// <summary>Wikidata property (P1646) of <see cref="DataType.Property"/></summary>
		[Type(DataType.Property)]
		MandatoryQualifier = 1646,

		/// <summary>Wikidata property (P1647) of <see cref="DataType.Property"/></summary>
		[Type(DataType.Property)]
		SubpropertyOf = 1647,

		/// <summary>Wikidata property (P1648) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DictionaryOfWelshBiographyID = 1648,

		/// <summary>Wikidata property (P1649) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KMDbPersonID = 1649,

		/// <summary>Wikidata property (P1650) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BBFIdentifier = 1650,

		/// <summary>Wikidata property (P1651) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		YouTubeVideoIdentifier = 1651,

		/// <summary>Wikidata property (P1652) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Referee = 1652,

		/// <summary>Wikidata property (P1653) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TERYTMunicipalityCode = 1653,

		/// <summary>Wikidata property (P1654) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		WingConfiguration = 1654,

		/// <summary>Wikidata property (P1655) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		StationNumber = 1655,

		/// <summary>Wikidata property (P1656) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		UnveiledBy = 1656,

		/// <summary>Wikidata property (P1657) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MPAAFilmRating = 1657,

		/// <summary>Wikidata property (P1658) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfFaces = 1658,

		/// <summary>Wikidata property (P1659) of <see cref="DataType.Property"/></summary>
		[Type(DataType.Property)]
		SeeAlso = 1659,

		/// <summary>Wikidata property (P1660) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HasIndexCase = 1660,

		/// <summary>Wikidata property (P1661) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		AlexaRank = 1661,

		/// <summary>Wikidata property (P1662) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DOIPrefix = 1662,

		/// <summary>Wikidata property (P1663) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ProCyclingStatsID = 1663,

		/// <summary>Wikidata property (P1664) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CyclingDatabaseID = 1664,

		/// <summary>Wikidata property (P1665) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ChessGamesID = 1665,

		/// <summary>Wikidata property (P1666) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ChessClubID = 1666,

		/// <summary>Wikidata property (P1667) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TGNIdentifier = 1667,

		/// <summary>Wikidata property (P1668) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ATCvet = 1668,

		/// <summary>Wikidata property (P1669) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CONAIdentifier = 1669,

		/// <summary>Wikidata property (P1670) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LACIdentifier = 1670,

		/// <summary>Wikidata property (P1671) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RouteNumber = 1671,

		/// <summary>Wikidata property (P1672) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ThisTaxonIsSourceOf = 1672,

		/// <summary>Wikidata property (P1673) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GeneralFormula = 1673,

		/// <summary>Wikidata property (P1674) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberConfirmed = 1674,

		/// <summary>Wikidata property (P1675) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberProbable = 1675,

		/// <summary>Wikidata property (P1676) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberSuspected = 1676,

		/// <summary>Wikidata property (P1677) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		IndexCaseOf = 1677,

		/// <summary>Wikidata property (P1678) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HasVertexFigure = 1678,

		/// <summary>Wikidata property (P1679) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BBCYourPaintingsArtworkIdentifier = 1679,

		/// <summary>Wikidata property (P1680) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		Subtitle = 1680,

		/// <summary>Wikidata property (P1683) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		Quote = 1683,

		/// <summary>Wikidata property (P1684) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		Inscription = 1684,

		/// <summary>Wikidata property (P1685) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PokemonBrowserNumber = 1685,

		/// <summary>Wikidata property (P1686) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ForWork = 1686,

		/// <summary>Wikidata property (P1687) of <see cref="DataType.Property"/></summary>
		[Type(DataType.Property)]
		WikidataProperty = 1687,

		/// <summary>Wikidata property (P1688) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AniDBIdentifier = 1688,

		/// <summary>Wikidata property (P1689) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		CentralGovernmentDebtAsAPercentOfGDP = 1689,

		/// <summary>Wikidata property (P1690) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ICD10PCS = 1690,

		/// <summary>Wikidata property (P1691) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OperationsAndProceduresKeyOPS = 1691,

		/// <summary>Wikidata property (P1692) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ICD9CM = 1692,

		/// <summary>Wikidata property (P1693) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TerminologiaEmbryologicaTE = 1693,

		/// <summary>Wikidata property (P1694) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TerminologiaHistologicaTH = 1694,

		/// <summary>Wikidata property (P1695) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NLPIdentifier = 1695,

		/// <summary>Wikidata property (P1696) of <see cref="DataType.Property"/></summary>
		[Type(DataType.Property)]
		InverseOf = 1696,

		/// <summary>Wikidata property (P1697) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		TotalValidVotes = 1697,

		/// <summary>Wikidata property (P1699) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SkyscraperPageBuildingId = 1699,

		/// <summary>Wikidata property (P1700) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SIPAIdentifier = 1700,

		/// <summary>Wikidata property (P1702) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IGESPARIdentifier = 1702,

		/// <summary>Wikidata property (P1703) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Pollination = 1703,

		/// <summary>Wikidata property (P1704) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Pollenizer = 1704,

		/// <summary>Wikidata property (P1705) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		NativeLabel = 1705,

		/// <summary>Wikidata property (P1706) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TogetherWith = 1706,

		/// <summary>Wikidata property (P1707) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DAAOIdentifier = 1707,

		/// <summary>Wikidata property (P1708) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LfDSObjectID = 1708,

		/// <summary>Wikidata property (P1709) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		EquivalentClass = 1709,

		/// <summary>Wikidata property (P1710) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SächsischeBiografie = 1710,

		/// <summary>Wikidata property (P1711) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BritishMuseumPersonInstitution = 1711,

		/// <summary>Wikidata property (P1712) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MetacriticID = 1712,

		/// <summary>Wikidata property (P1713) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		BiographyAtTheBundestagOfGermany = 1713,

		/// <summary>Wikidata property (P1714) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		JournalistedID = 1714,

		/// <summary>Wikidata property (P1715) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RKDESDIdentifierSlovenia = 1715,

		/// <summary>Wikidata property (P1716) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Brand = 1716,

		/// <summary>Wikidata property (P1717) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SANDREID = 1717,

		/// <summary>Wikidata property (P1721) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PinyinTransliteration = 1721,

		/// <summary>Wikidata property (P1725) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		BeatsPerMinute = 1725,

		/// <summary>Wikidata property (P1726) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FlorentineMuseaInventario1890ID = 1726,

		/// <summary>Wikidata property (P1727) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FloraOfNorthAmericaTaxonID = 1727,

		/// <summary>Wikidata property (P1728) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AllMusicArtistID = 1728,

		/// <summary>Wikidata property (P1729) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AllMusicAlbumID = 1729,

		/// <summary>Wikidata property (P1730) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AllMusicSongID = 1730,

		/// <summary>Wikidata property (P1731) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Fach = 1731,

		/// <summary>Wikidata property (P1732) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NaturbaseID = 1732,

		/// <summary>Wikidata property (P1733) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SteamID = 1733,

		/// <summary>Wikidata property (P1734) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		OathOfOfficeDate = 1734,

		/// <summary>Wikidata property (P1735) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ComedienChIdentifier = 1735,

		/// <summary>Wikidata property (P1736) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		InformationCenterForIsraeliArtArtistIdentifier = 1736,

		/// <summary>Wikidata property (P1738) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MerckIndexMonograph = 1738,

		/// <summary>Wikidata property (P1739) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CiNiiBookIdentifer = 1739,

		/// <summary>Wikidata property (P1740) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CategoryForFilmsShotAtThisLocation = 1740,

		/// <summary>Wikidata property (P1741) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GTAAId = 1741,

		/// <summary>Wikidata property (P1743) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BradleyAndFletcherChecklistNumber = 1743,

		/// <summary>Wikidata property (P1744) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AgassizEtAlChecklistNumber = 1744,

		/// <summary>Wikidata property (P1745) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		VASCANID = 1745,

		/// <summary>Wikidata property (P1746) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ZooBankNomenclaturalAct = 1746,

		/// <summary>Wikidata property (P1747) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FloraOfChinaID = 1747,

		/// <summary>Wikidata property (P1748) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NCIThesaurusID = 1748,

		/// <summary>Wikidata property (P1749) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ParlementAndPolitiekID = 1749,

		/// <summary>Wikidata property (P1750) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		NameDay = 1750,

		/// <summary>Wikidata property (P1751) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BBCYourPaintingsCollectionIdentifier = 1751,

		/// <summary>Wikidata property (P1752) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Scale = 1752,

		/// <summary>Wikidata property (P1753) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ListRelatedToCategory = 1753,

		/// <summary>Wikidata property (P1754) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CategoryRelatedToList = 1754,

		/// <summary>Wikidata property (P1755) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AviationSafetyNetworkAccidentDescriptionID = 1755,

		/// <summary>Wikidata property (P1760) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AviationSafetyNetworkWikibaseOccurrence = 1760,

		/// <summary>Wikidata property (P1761) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WatsonAndDallwitzFamilyID = 1761,

		/// <summary>Wikidata property (P1762) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HornbostelSachsClassification = 1762,

		/// <summary>Wikidata property (P1763) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NationalPipeOrganRegisterIdentifier = 1763,

		/// <summary>Wikidata property (P1764) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FlemishOrganizationForImmovableHeritageRelictID = 1764,

		/// <summary>Wikidata property (P1766) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		PlaceNameSign = 1766,

		/// <summary>Wikidata property (P1769) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DenkXwebIdentifier = 1769,

		/// <summary>Wikidata property (P1770) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RomaniaLMICode = 1770,

		/// <summary>Wikidata property (P1771) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IntegratedPostsecondaryEducationDataSystemIdentifier = 1771,

		/// <summary>Wikidata property (P1772) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		USDAPLANTSID = 1772,

		/// <summary>Wikidata property (P1773) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AttributedTo = 1773,

		/// <summary>Wikidata property (P1774) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		WorkshopOf = 1774,

		/// <summary>Wikidata property (P1775) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FollowerOf = 1775,

		/// <summary>Wikidata property (P1776) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CircleOf = 1776,

		/// <summary>Wikidata property (P1777) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MannerOf = 1777,

		/// <summary>Wikidata property (P1778) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ForgeryAfter = 1778,

		/// <summary>Wikidata property (P1779) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PossibleCreator = 1779,

		/// <summary>Wikidata property (P1780) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SchoolOf = 1780,

		/// <summary>Wikidata property (P1782) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CourtesyName = 1782,

		/// <summary>Wikidata property (P1785) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TempleName = 1785,

		/// <summary>Wikidata property (P1786) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PosthumousName = 1786,

		/// <summary>Wikidata property (P1787) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ArtName = 1787,

		/// <summary>Wikidata property (P1788) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DVNIdentifier = 1788,

		/// <summary>Wikidata property (P1789) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ChiefOperatingOfficer = 1789,

		/// <summary>Wikidata property (P1790) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BioStorAuthorIdentifier = 1790,

		/// <summary>Wikidata property (P1791) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CategoryOfPeopleBuriedHere = 1791,

		/// <summary>Wikidata property (P1792) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CategoryOfAssociatedPeople = 1792,

		/// <summary>Wikidata property (P1793) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FormatAsARegularExpression = 1793,

		/// <summary>Wikidata property (P1794) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BureauDuPatrimoineDeSeineSaintDenisID = 1794,

		/// <summary>Wikidata property (P1795) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SmithsonianAmericanArtMuseumPersonInstitutionThesaurusId = 1795,

		/// <summary>Wikidata property (P1796) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		InternationalStandardIndustrialClassificationCode = 1796,

		/// <summary>Wikidata property (P1798) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISO6395Code = 1798,

		/// <summary>Wikidata property (P1799) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MalteseIslandsNationalInventoryOfCulturalPropertyIdentifier = 1799,

		/// <summary>Wikidata property (P1800) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WikimediaDatabaseName = 1800,

		/// <summary>Wikidata property (P1801) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		CommemorativePlaqueImage = 1801,

		/// <summary>Wikidata property (P1802) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EMLOPersonIdentifier = 1802,

		/// <summary>Wikidata property (P1803) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MasarykUniversityPersonID = 1803,

		/// <summary>Wikidata property (P1804) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DanishNationalFilmographyID = 1804,

		/// <summary>Wikidata property (P1805) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WorldHealthOrganisationInternationalNonproprietaryName = 1805,

		/// <summary>Wikidata property (P1806) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ABoKNumber = 1806,

		/// <summary>Wikidata property (P1807) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GreatAragoneseEncyclopediaID = 1807,

		/// <summary>Wikidata property (P1808) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SenatFrID = 1808,

		/// <summary>Wikidata property (P1809) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Choreographer = 1809,

		/// <summary>Wikidata property (P1810) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NamedAs = 1810,

		/// <summary>Wikidata property (P1811) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ListOfEpisodes = 1811,

		/// <summary>Wikidata property (P1813) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		ShortName = 1813,

		/// <summary>Wikidata property (P1814) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NameInKana = 1814,

		/// <summary>Wikidata property (P1815) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RSLScannedBooksIdentifier = 1815,

		/// <summary>Wikidata property (P1816) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NationalPortraitGalleryLondonPersonIdentifier = 1816,

		/// <summary>Wikidata property (P1817) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Addressee = 1817,

		/// <summary>Wikidata property (P1818) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KH = 1818,

		/// <summary>Wikidata property (P1819) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GenealogicsOrgPersonID = 1819,

		/// <summary>Wikidata property (P1820) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OpenFoodFactsFoodAdditiveSlug = 1820,

		/// <summary>Wikidata property (P1821) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OpenFoodFactsFoodCategorySlug = 1821,

		/// <summary>Wikidata property (P1822) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DSHObjectID = 1822,

		/// <summary>Wikidata property (P1823) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BAnQID = 1823,

		/// <summary>Wikidata property (P1824) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RoadNumber = 1824,

		/// <summary>Wikidata property (P1825) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BaseballReferenceComMajorLeaguePlayerID = 1825,

		/// <summary>Wikidata property (P1826) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BaseballReferenceComMinorLeaguePlayerID = 1826,

		/// <summary>Wikidata property (P1827) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISWC = 1827,

		/// <summary>Wikidata property (P1828) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IPINumber = 1828,

		/// <summary>Wikidata property (P1829) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RoudFolkSongIndex = 1829,

		/// <summary>Wikidata property (P1830) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OwnerOf = 1830,

		/// <summary>Wikidata property (P1831) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Electorate = 1831,

		/// <summary>Wikidata property (P1832) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GrassBaseID = 1832,

		/// <summary>Wikidata property (P1833) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfRegisteredUsersContributors = 1833,

		/// <summary>Wikidata property (P1836) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DraftPickNumber = 1836,

		/// <summary>Wikidata property (P1837) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GaoloumiID = 1837,

		/// <summary>Wikidata property (P1838) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PSSArchiID = 1838,

		/// <summary>Wikidata property (P1839) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		USFederalElectionCommissionIdentifier = 1839,

		/// <summary>Wikidata property (P1840) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		InvestigatedBy = 1840,

		/// <summary>Wikidata property (P1841) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SwedishDistrictCode = 1841,

		/// <summary>Wikidata property (P1842) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GlobalAnabaptistMennoniteEncyclopediaOnlineIdentifier = 1842,

		/// <summary>Wikidata property (P1843) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		TaxonCommonName = 1843,

		/// <summary>Wikidata property (P1844) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HathiTrustId = 1844,

		/// <summary>Wikidata property (P1845) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AntiVirusAlias = 1845,

		/// <summary>Wikidata property (P1846) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		DistributionMap = 1846,

		/// <summary>Wikidata property (P1847) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NasjonalbiblioteketPhotographerID = 1847,

		/// <summary>Wikidata property (P1848) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		INPNCode = 1848,

		/// <summary>Wikidata property (P1849) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SSRWrittenFormID = 1849,

		/// <summary>Wikidata property (P1850) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SSRNameID = 1850,

		/// <summary>Wikidata property (P1851) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		InputSet = 1851,

		/// <summary>Wikidata property (P1852) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PerryIndex = 1852,

		/// <summary>Wikidata property (P1853) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		BloodType = 1853,

		/// <summary>Wikidata property (P1854) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KievStreetCode = 1854,

		/// <summary>Wikidata property (P1855) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		WikidataPropertyExample = 1855,

		/// <summary>Wikidata property (P1856) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		WikidataExampleMediaFile = 1856,

		/// <summary>Wikidata property (P1858) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WikidataExampleString = 1858,

		/// <summary>Wikidata property (P1859) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		WikidataExampleItemValue = 1859,

		/// <summary>Wikidata property (P1860) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		WikidataExampleURL = 1860,

		/// <summary>Wikidata property (P1861) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		WikidataExampleTime = 1861,

		/// <summary>Wikidata property (P1862) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		WikidataExampleQuantity = 1862,

		/// <summary>Wikidata property (P1863) of <see cref="DataType.Property"/></summary>
		[Type(DataType.Property)]
		WikidataExamplePropertyValue = 1863,

		/// <summary>Wikidata property (P1864) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		WikidataExampleMonolingualText = 1864,

		/// <summary>Wikidata property (P1865) of <see cref="DataType.GlobeCoordinate"/></summary>
		[Type(DataType.GlobeCoordinate)]
		WikidataExampleGeographicCoordinates = 1865,

		/// <summary>Wikidata property (P1866) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CatholicHierarchyDioceseID = 1866,

		/// <summary>Wikidata property (P1867) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		EligibleVoters = 1867,

		/// <summary>Wikidata property (P1868) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		BallotsCast = 1868,

		/// <summary>Wikidata property (P1869) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HallOfValorID = 1869,

		/// <summary>Wikidata property (P1870) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NameAssigningAuthorityNumber = 1870,

		/// <summary>Wikidata property (P1871) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CERLID = 1871,

		/// <summary>Wikidata property (P1872) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MinimumNumberOfPlayers = 1872,

		/// <summary>Wikidata property (P1873) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MaximumNumberOfPlayers = 1873,

		/// <summary>Wikidata property (P1874) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NetflixIdentifier = 1874,

		/// <summary>Wikidata property (P1875) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		RepresentedBy = 1875,

		/// <summary>Wikidata property (P1876) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Spacecraft = 1876,

		/// <summary>Wikidata property (P1877) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AfterAWorkBy = 1877,

		/// <summary>Wikidata property (P1878) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		VoxATypIClassification = 1878,

		/// <summary>Wikidata property (P1879) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		IncomeClassificationPhilippines = 1879,

		/// <summary>Wikidata property (P1880) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MeasuredBy = 1880,

		/// <summary>Wikidata property (P1881) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ListOfCharacters = 1881,

		/// <summary>Wikidata property (P1882) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WebGalleryOfArtIdentifier = 1882,

		/// <summary>Wikidata property (P1883) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DeclaratorOrgID = 1883,

		/// <summary>Wikidata property (P1884) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HairColor = 1884,

		/// <summary>Wikidata property (P1885) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Cathedral = 1885,

		/// <summary>Wikidata property (P1886) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SmithsonianVolcanoIdentifier = 1886,

		/// <summary>Wikidata property (P1887) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ViceCounty = 1887,

		/// <summary>Wikidata property (P1888) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DictionaryOfMedievalNamesFromEuropeanSourcesEntry = 1888,

		/// <summary>Wikidata property (P1889) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DifferentFrom = 1889,

		/// <summary>Wikidata property (P1890) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BNCIdentifier = 1890,

		/// <summary>Wikidata property (P1891) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Signatory = 1891,

		/// <summary>Wikidata property (P1893) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OpenPlaquesPlaqueIdentifier = 1893,

		/// <summary>Wikidata property (P1894) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DanishUrbanAreaCode = 1894,

		/// <summary>Wikidata property (P1895) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FaunaEuropaeaID = 1895,

		/// <summary>Wikidata property (P1896) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		SourceWebsiteForTheProperty = 1896,

		/// <summary>Wikidata property (P1897) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HighestNote = 1897,

		/// <summary>Wikidata property (P1898) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		LowestNote = 1898,

		/// <summary>Wikidata property (P1899) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LibrivoxAuthorID = 1899,

		/// <summary>Wikidata property (P1900) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EAGLEId = 1900,

		/// <summary>Wikidata property (P1901) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BALaTPersonOrganisationId = 1901,

		/// <summary>Wikidata property (P1902) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SpotifyArtistID = 1902,

		/// <summary>Wikidata property (P1903) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		VolcanicExplosivityIndex = 1903,

		/// <summary>Wikidata property (P1905) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		FundRefRegistryName = 1905,

		/// <summary>Wikidata property (P1906) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OfficeHeldByHeadOfState = 1906,

		/// <summary>Wikidata property (P1907) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AustralianDictionaryOfBiographyIdentifier = 1907,

		/// <summary>Wikidata property (P1908) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CommonwealthWarGravesCommissionPersonIdentifier = 1908,

		/// <summary>Wikidata property (P1909) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SideEffect = 1909,

		/// <summary>Wikidata property (P1910) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DecreasedExpressionIn = 1910,

		/// <summary>Wikidata property (P1911) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		IncreasedExpressionIn = 1911,

		/// <summary>Wikidata property (P1912) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DeletionAssociationWith = 1912,

		/// <summary>Wikidata property (P1913) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		GeneDuplicationAssociationWith = 1913,

		/// <summary>Wikidata property (P1914) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		GeneInsertionAssociationWith = 1914,

		/// <summary>Wikidata property (P1915) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		GeneInversionAssociationWith = 1915,

		/// <summary>Wikidata property (P1916) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		GeneSubstitutionAssociationWith = 1916,

		/// <summary>Wikidata property (P1917) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PosttranslationalModificationAssociationWith = 1917,

		/// <summary>Wikidata property (P1918) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AlteredRegulationLeadsTo = 1918,

		/// <summary>Wikidata property (P1919) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MinistryOfEducationOfChileSchoolID = 1919,

		/// <summary>Wikidata property (P1920) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CommonwealthWarGravesCommissionBurialGroundIdentifier = 1920,

		/// <summary>Wikidata property (P1921) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		URIPatternForRDFResource = 1921,

		/// <summary>Wikidata property (P1922) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		FirstLine = 1922,

		/// <summary>Wikidata property (P1923) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ParticipatingTeam = 1923,

		/// <summary>Wikidata property (P1924) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		VaccineFor = 1924,

		/// <summary>Wikidata property (P1925) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		VIOLINID = 1925,

		/// <summary>Wikidata property (P1928) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		VaccineOntologyID = 1928,

		/// <summary>Wikidata property (P1929) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ClinvarAccessionNumber = 1929,

		/// <summary>Wikidata property (P1930) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DSMV = 1930,

		/// <summary>Wikidata property (P1931) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NPGID = 1931,

		/// <summary>Wikidata property (P1932) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		StatedAs = 1932,

		/// <summary>Wikidata property (P1933) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MobyGamesID = 1933,

		/// <summary>Wikidata property (P1934) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AnimatorRuFilmID = 1934,

		/// <summary>Wikidata property (P1935) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DBCSID = 1935,

		/// <summary>Wikidata property (P1936) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DigitalAtlasOfTheRomanEmpireID = 1936,

		/// <summary>Wikidata property (P1937) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UNLOCODE = 1937,

		/// <summary>Wikidata property (P1938) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ProjectGutenbergAuthorID = 1938,

		/// <summary>Wikidata property (P1939) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DyntaxaID = 1939,

		/// <summary>Wikidata property (P1940) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ConifersOrgID = 1940,

		/// <summary>Wikidata property (P1942) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		McCuneReischauerRomanization = 1942,

		/// <summary>Wikidata property (P1943) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		LocationMap = 1943,

		/// <summary>Wikidata property (P1944) of <see cref="DataType.CommonsMediaFile"/></summary>
		[Type(DataType.CommonsMediaFile)]
		ReliefLocationMap = 1944,

		/// <summary>Wikidata property (P1945) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		StreetKey = 1945,

		/// <summary>Wikidata property (P1946) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NationalLibraryOfIrelandAuthority = 1946,

		/// <summary>Wikidata property (P1947) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MapillaryID = 1947,

		/// <summary>Wikidata property (P1948) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BerlPapIdentifier = 1948,

		/// <summary>Wikidata property (P1949) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CulturaItaliaID = 1949,

		/// <summary>Wikidata property (P1950) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SecondSurnameInSpanishName = 1950,

		/// <summary>Wikidata property (P1951) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Investor = 1951,

		/// <summary>Wikidata property (P1952) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EncyclopaediaMetallumBandID = 1952,

		/// <summary>Wikidata property (P1953) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DiscogsArtistID = 1953,

		/// <summary>Wikidata property (P1954) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DiscogsMasterID = 1954,

		/// <summary>Wikidata property (P1955) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DiscogsLabelID = 1955,

		/// <summary>Wikidata property (P1956) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		TakeoffAndLandingCapability = 1956,

		/// <summary>Wikidata property (P1957) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		WikisourceIndexPage = 1957,

		/// <summary>Wikidata property (P1958) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TrismegistosGeoID = 1958,

		/// <summary>Wikidata property (P1959) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DutchSenatePersonID = 1959,

		/// <summary>Wikidata property (P1960) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GoogleScholarID = 1960,

		/// <summary>Wikidata property (P1961) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IdentifierOfComiteDesTravauxHistoriquesEtScientifiques = 1961,

		/// <summary>Wikidata property (P1962) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Patron = 1962,

		/// <summary>Wikidata property (P1963) of <see cref="DataType.Property"/></summary>
		[Type(DataType.Property)]
		PropertiesForThisType = 1963,

		/// <summary>Wikidata property (P1966) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BibliotecaNacionalDeChileCatalogueNumber = 1966,

		/// <summary>Wikidata property (P1967) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BoxRecID = 1967,

		/// <summary>Wikidata property (P1968) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FoursquareVenueID = 1968,

		/// <summary>Wikidata property (P1969) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MovieMeterDirectorID = 1969,

		/// <summary>Wikidata property (P1970) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MovieMeterMovieID = 1970,

		/// <summary>Wikidata property (P1971) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NumberOfChildren = 1971,

		/// <summary>Wikidata property (P1972) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OpenHubID = 1972,

		/// <summary>Wikidata property (P1973) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RSLEditions = 1973,

		/// <summary>Wikidata property (P1976) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		INEGILocalityIdentifier = 1976,

		/// <summary>Wikidata property (P1977) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LesarchivesduspectacleID = 1977,

		/// <summary>Wikidata property (P1978) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		USDANDBNumber = 1978,

		/// <summary>Wikidata property (P1979) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RighteousAmongTheNationsID = 1979,

		/// <summary>Wikidata property (P1980) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PolSysID = 1980,

		/// <summary>Wikidata property (P1981) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FSKFilmRating = 1981,

		/// <summary>Wikidata property (P1982) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AnimeNewsNetworkPersonID = 1982,

		/// <summary>Wikidata property (P1983) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AnimeNewsNetworkCompanyID = 1983,

		/// <summary>Wikidata property (P1984) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AnimeNewsNetworkMangaID = 1984,

		/// <summary>Wikidata property (P1985) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AnimeNewsNetworkAnimeID = 1985,

		/// <summary>Wikidata property (P1986) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DizionarioBiograficoDegliItaliani = 1986,

		/// <summary>Wikidata property (P1987) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MCNCode = 1987,

		/// <summary>Wikidata property (P1988) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DelargeID = 1988,

		/// <summary>Wikidata property (P1989) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EncyclopaediaMetallumArtistID = 1989,

		/// <summary>Wikidata property (P1990) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SpeciesKept = 1990,

		/// <summary>Wikidata property (P1991) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		LPSNURL = 1991,

		/// <summary>Wikidata property (P1992) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PlaziID = 1992,

		/// <summary>Wikidata property (P1993) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TeXString = 1993,

		/// <summary>Wikidata property (P1994) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AllMusicCompositionID = 1994,

		/// <summary>Wikidata property (P1995) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MedicalSpecialty = 1995,

		/// <summary>Wikidata property (P1996) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ParliamentUkID = 1996,

		/// <summary>Wikidata property (P1997) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FacebookPlacesID = 1997,

		/// <summary>Wikidata property (P1998) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UCICode = 1998,

		/// <summary>Wikidata property (P1999) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		UNESCOLanguageStatus = 1999,

		/// <summary>Wikidata property (P2000) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CPDLID = 2000,

		/// <summary>Wikidata property (P2001) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RevisedRomanisation = 2001,

		/// <summary>Wikidata property (P2002) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TwitterUsername = 2002,

		/// <summary>Wikidata property (P2003) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		InstagramUsername = 2003,

		/// <summary>Wikidata property (P2004) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NALTId = 2004,

		/// <summary>Wikidata property (P2005) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CatalogusProfessorumHalensis = 2005,

		/// <summary>Wikidata property (P2006) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ZooBankAuthorID = 2006,

		/// <summary>Wikidata property (P2007) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ZooBankPublicationID = 2007,

		/// <summary>Wikidata property (P2008) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IPNIPublicationID = 2008,

		/// <summary>Wikidata property (P2009) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ExifModel = 2009,

		/// <summary>Wikidata property (P2010) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ExifMake = 2010,

		/// <summary>Wikidata property (P2011) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CooperHewittPersonID = 2011,

		/// <summary>Wikidata property (P2012) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Cuisine = 2012,

		/// <summary>Wikidata property (P2013) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FacebookID = 2013,

		/// <summary>Wikidata property (P2014) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MoMAArtworkId = 2014,

		/// <summary>Wikidata property (P2015) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HansardID = 2015,

		/// <summary>Wikidata property (P2016) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CatalogusProfessorumAcademiaeGroninganaeId = 2016,

		/// <summary>Wikidata property (P2017) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		IsomericSMILES = 2017,

		/// <summary>Wikidata property (P2018) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TeuchosID = 2018,

		/// <summary>Wikidata property (P2019) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AllMovieArtistID = 2019,

		/// <summary>Wikidata property (P2020) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WorldfootballNetID = 2020,

		/// <summary>Wikidata property (P2021) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		ErdősNumber = 2021,

		/// <summary>Wikidata property (P2024) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GermanCattleBreedID = 2024,

		/// <summary>Wikidata property (P2025) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FindAGraveCemeteryID = 2025,

		/// <summary>Wikidata property (P2026) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AvibaseID = 2026,

		/// <summary>Wikidata property (P2027) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ColourIndexInternationalConstitutionID = 2027,

		/// <summary>Wikidata property (P2028) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UnitedStatesArmedForcesServiceNumber = 2028,

		/// <summary>Wikidata property (P2029) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DictionaryOfUlsterBiographyID = 2029,

		/// <summary>Wikidata property (P2030) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NASABiographicalID = 2030,

		/// <summary>Wikidata property (P2031) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		WorkPeriodStart = 2031,

		/// <summary>Wikidata property (P2032) of <see cref="DataType.Time"/></summary>
		[Type(DataType.Time)]
		WorkPeriodEnd = 2032,

		/// <summary>Wikidata property (P2033) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CategoryForPicturesTakenWithCamera = 2033,

		/// <summary>Wikidata property (P2034) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ProjectGutenbergEbookID = 2034,

		/// <summary>Wikidata property (P2035) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		LinkedInPersonalProfile = 2035,

		/// <summary>Wikidata property (P2036) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AfricanPlantDatabase = 2036,

		/// <summary>Wikidata property (P2037) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GitHubUsername = 2037,

		/// <summary>Wikidata property (P2038) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ResearchGateID = 2038,

		/// <summary>Wikidata property (P2040) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CITESSpeciesID = 2040,

		/// <summary>Wikidata property (P2041) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NationalGalleryOfVictoriaArtistIdentifier = 2041,

		/// <summary>Wikidata property (P2042) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ArtsyArtist = 2042,

		/// <summary>Wikidata property (P2043) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Length = 2043,

		/// <summary>Wikidata property (P2044) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		ElevationAboveSeaLevel = 2044,

		/// <summary>Wikidata property (P2045) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		OrbitalInclination = 2045,

		/// <summary>Wikidata property (P2046) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Area = 2046,

		/// <summary>Wikidata property (P2047) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		RunningTime = 2047,

		/// <summary>Wikidata property (P2048) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Height = 2048,

		/// <summary>Wikidata property (P2049) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Width = 2049,

		/// <summary>Wikidata property (P2050) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Wingspan = 2050,

		/// <summary>Wikidata property (P2051) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MSinI = 2051,

		/// <summary>Wikidata property (P2052) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Speed = 2052,

		/// <summary>Wikidata property (P2053) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		WatershedArea = 2053,

		/// <summary>Wikidata property (P2054) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Density = 2054,

		/// <summary>Wikidata property (P2055) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		ElectricalConductivity = 2055,

		/// <summary>Wikidata property (P2056) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		HeatCapacity = 2056,

		/// <summary>Wikidata property (P2057) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HMDBID = 2057,

		/// <summary>Wikidata property (P2058) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Depositor = 2058,

		/// <summary>Wikidata property (P2060) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Luminosity = 2060,

		/// <summary>Wikidata property (P2061) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		AspectRatio = 2061,

		/// <summary>Wikidata property (P2062) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HSDBID = 2062,

		/// <summary>Wikidata property (P2063) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LIPIDMAPSID = 2063,

		/// <summary>Wikidata property (P2064) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KNApSAcKID = 2064,

		/// <summary>Wikidata property (P2065) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NIAIDChemDBID = 2065,

		/// <summary>Wikidata property (P2066) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		FusionEnthalpy = 2066,

		/// <summary>Wikidata property (P2067) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MassWeight = 2067,

		/// <summary>Wikidata property (P2068) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		ThermalConductivity = 2068,

		/// <summary>Wikidata property (P2069) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MagneticMoment = 2069,

		/// <summary>Wikidata property (P2070) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FellowOfTheRoyalSociety = 2070,

		/// <summary>Wikidata property (P2071) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MemoireDesHommes = 2071,

		/// <summary>Wikidata property (P2072) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CDBChemicalID = 2072,

		/// <summary>Wikidata property (P2073) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Range = 2073,

		/// <summary>Wikidata property (P2074) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		InternetmedicinSeID = 2074,

		/// <summary>Wikidata property (P2075) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		SpeedOfSound = 2075,

		/// <summary>Wikidata property (P2076) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Temperature = 2076,

		/// <summary>Wikidata property (P2077) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Pressure = 2077,

		/// <summary>Wikidata property (P2078) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		UserManualLink = 2078,

		/// <summary>Wikidata property (P2079) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FabricationMethod = 2079,

		/// <summary>Wikidata property (P2080) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		AcademiaNet = 2080,

		/// <summary>Wikidata property (P2081) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BLDAMObjectID = 2081,

		/// <summary>Wikidata property (P2082) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		M49Code = 2082,

		/// <summary>Wikidata property (P2083) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LeadscopeID = 2083,

		/// <summary>Wikidata property (P2084) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ZINCID = 2084,

		/// <summary>Wikidata property (P2085) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		Nikkaji = 2085,

		/// <summary>Wikidata property (P2086) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CDDPublicID = 2086,

		/// <summary>Wikidata property (P2087) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CrunchBasePersonID = 2087,

		/// <summary>Wikidata property (P2088) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CrunchBaseOrganisationID = 2088,

		/// <summary>Wikidata property (P2089) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		LibraryOfCongressJukeBoxID = 2089,

		/// <summary>Wikidata property (P2090) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PowerOf10AthleteID = 2090,

		/// <summary>Wikidata property (P2091) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FISAID = 2091,

		/// <summary>Wikidata property (P2092) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BildindexDerKunstUndArchitekturID = 2092,

		/// <summary>Wikidata property (P2093) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ShortAuthorName = 2093,

		/// <summary>Wikidata property (P2094) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CompetitionClass = 2094,

		/// <summary>Wikidata property (P2095) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		CoDriver = 2095,

		/// <summary>Wikidata property (P2096) of <see cref="DataType.MonolingualText"/></summary>
		[Type(DataType.MonolingualText)]
		ImageLegend = 2096,

		/// <summary>Wikidata property (P2097) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		TermLengthOfOffice = 2097,

		/// <summary>Wikidata property (P2098) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SubstituteDeputyReplacementOfOfficeOfficeholder = 2098,

		/// <summary>Wikidata property (P2099) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BCGeographicalNamesID = 2099,

		/// <summary>Wikidata property (P2100) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BanqueDeNomsDeLieuxDuQuebecId = 2100,

		/// <summary>Wikidata property (P2101) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MeltingPoint = 2101,

		/// <summary>Wikidata property (P2102) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		BoilingPoint = 2102,

		/// <summary>Wikidata property (P2103) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		SizeOfTeamAtStart = 2103,

		/// <summary>Wikidata property (P2105) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		SizeOfTeamAtFinish = 2105,

		/// <summary>Wikidata property (P2106) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RXNOOntology = 2106,

		/// <summary>Wikidata property (P2107) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		DecompositionPoint = 2107,

		/// <summary>Wikidata property (P2108) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KunstindexDanmarkArtworkID = 2108,

		/// <summary>Wikidata property (P2109) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		PowerOutput = 2109,

		/// <summary>Wikidata property (P2112) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		WingArea = 2112,

		/// <summary>Wikidata property (P2113) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		SublimationTemperature = 2113,

		/// <summary>Wikidata property (P2114) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		HalfLife = 2114,

		/// <summary>Wikidata property (P2115) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NDFRTID = 2115,

		/// <summary>Wikidata property (P2116) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		EnthalpyOfVaporization = 2116,

		/// <summary>Wikidata property (P2117) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		CombustionEnthalpy = 2117,

		/// <summary>Wikidata property (P2118) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		KinematicViscosity = 2118,

		/// <summary>Wikidata property (P2119) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		VaporPressure = 2119,

		/// <summary>Wikidata property (P2120) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Radius = 2120,

		/// <summary>Wikidata property (P2121) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		PrizeMoney = 2121,

		/// <summary>Wikidata property (P2123) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		YerelNetVillageID = 2123,

		/// <summary>Wikidata property (P2124) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Membership = 2124,

		/// <summary>Wikidata property (P2125) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RevisedHepburnRomanization = 2125,

		/// <summary>Wikidata property (P2126) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GeorgianNationalSystemOfRomanization = 2126,

		/// <summary>Wikidata property (P2127) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		InternationalNuclearEventScale = 2127,

		/// <summary>Wikidata property (P2128) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		FlashPoint = 2128,

		/// <summary>Wikidata property (P2129) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		IDLH = 2129,

		/// <summary>Wikidata property (P2130) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Cost = 2130,

		/// <summary>Wikidata property (P2131) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NominalGrossDomesticProduct = 2131,

		/// <summary>Wikidata property (P2132) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		GDPPerCapita = 2132,

		/// <summary>Wikidata property (P2133) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		TotalDebt = 2133,

		/// <summary>Wikidata property (P2134) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		TotalReserves = 2134,

		/// <summary>Wikidata property (P2135) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		TotalExports = 2135,

		/// <summary>Wikidata property (P2136) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		TotalImports = 2136,

		/// <summary>Wikidata property (P2137) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		TotalEquity = 2137,

		/// <summary>Wikidata property (P2138) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		TotalLiabilities = 2138,

		/// <summary>Wikidata property (P2139) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		TotalRevenue = 2139,

		/// <summary>Wikidata property (P2140) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		ForeignDirectInvestmentNetOutflows = 2140,

		/// <summary>Wikidata property (P2141) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		ForeignDirectInvestmentNetInflows = 2141,

		/// <summary>Wikidata property (P2142) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		BoxOffice = 2142,

		/// <summary>Wikidata property (P2143) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		GenomeSize = 2143,

		/// <summary>Wikidata property (P2144) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Frequency = 2144,

		/// <summary>Wikidata property (P2145) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		ExplosiveEnergyEquivalent = 2145,

		/// <summary>Wikidata property (P2146) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		OrbitalPeriod = 2146,

		/// <summary>Wikidata property (P2147) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		RotationPeriod = 2147,

		/// <summary>Wikidata property (P2148) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		DistanceFromRiverMouth = 2148,

		/// <summary>Wikidata property (P2149) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		ClockSpeed = 2149,

		/// <summary>Wikidata property (P2150) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		FSBSpeed = 2150,

		/// <summary>Wikidata property (P2151) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		FocalLength = 2151,

		/// <summary>Wikidata property (P2152) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Antiparticle = 2152,

		/// <summary>Wikidata property (P2153) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PubChemSubstanceID = 2153,

		/// <summary>Wikidata property (P2154) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		BindingEnergy = 2154,

		/// <summary>Wikidata property (P2155) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		SolidSolutionSeriesWith = 2155,

		/// <summary>Wikidata property (P2156) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		PseudoCrystalHabit = 2156,

		/// <summary>Wikidata property (P2157) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Lithography = 2157,

		/// <summary>Wikidata property (P2158) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CellLineOntologyID = 2158,

		/// <summary>Wikidata property (P2159) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Solves = 2159,

		/// <summary>Wikidata property (P2160) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MassExcess = 2160,

		/// <summary>Wikidata property (P2161) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		GuthrieCode = 2161,

		/// <summary>Wikidata property (P2162) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DeutscheUltramarathonVereinigungID = 2162,

		/// <summary>Wikidata property (P2163) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FASTID = 2163,

		/// <summary>Wikidata property (P2164) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SIGICPerson = 2164,

		/// <summary>Wikidata property (P2165) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SIGICGroup = 2165,

		/// <summary>Wikidata property (P2166) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SIGICInstitution = 2166,

		/// <summary>Wikidata property (P2167) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		UnitedNationsStandardProductsAndServicesCode = 2167,

		/// <summary>Wikidata property (P2168) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SwedishFilmDatabasePersonID = 2168,

		/// <summary>Wikidata property (P2169) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PublicWhipIdentifier = 2169,

		/// <summary>Wikidata property (P2170) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		HansardCurrentsSessionIdentifier = 2170,

		/// <summary>Wikidata property (P2171) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		TheyWorkForYouIdentifier = 2171,

		/// <summary>Wikidata property (P2172) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ParliamentaryRecordIdentifier = 2172,

		/// <summary>Wikidata property (P2173) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BBCNewsDemocracyLiveIdentifier = 2173,

		/// <summary>Wikidata property (P2174) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MoMAArtistId = 2174,

		/// <summary>Wikidata property (P2175) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		MedicalConditionTreated = 2175,

		/// <summary>Wikidata property (P2176) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		DrugUsedForTreatment = 2176,

		/// <summary>Wikidata property (P2177) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Solubility = 2177,

		/// <summary>Wikidata property (P2178) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		Solvent = 2178,

		/// <summary>Wikidata property (P2179) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ACMClassificationCode2012 = 2179,

		/// <summary>Wikidata property (P2180) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		KansallisbiografiaID = 2180,

		/// <summary>Wikidata property (P2181) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FinnishMPID = 2181,

		/// <summary>Wikidata property (P2182) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FinnishMinistersDatabaseID = 2182,

		/// <summary>Wikidata property (P2183) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISO91995 = 2183,

		/// <summary>Wikidata property (P2184) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		HistoryOfTopic = 2184,

		/// <summary>Wikidata property (P2185) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DLIIdentifier = 2185,

		/// <summary>Wikidata property (P2186) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		WikiLovesMonumentsID = 2186,

		/// <summary>Wikidata property (P2187) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BiblioNetPublicationIdentifier = 2187,

		/// <summary>Wikidata property (P2188) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BiblioNetAuthorIdentifier = 2188,

		/// <summary>Wikidata property (P2189) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		BiblioNetPublisherIdentifier = 2189,

		/// <summary>Wikidata property (P2190) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		CSPANIdentifierOfAPerson = 2190,

		/// <summary>Wikidata property (P2191) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NILFAuthorId = 2191,

		/// <summary>Wikidata property (P2192) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EndangeredlanguagesComID = 2192,

		/// <summary>Wikidata property (P2193) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SoccerbasePlayerId = 2193,

		/// <summary>Wikidata property (P2194) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PSSArchiArchitectId = 2194,

		/// <summary>Wikidata property (P2195) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SoccerbaseManagerId = 2195,

		/// <summary>Wikidata property (P2196) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		StudentsCount = 2196,

		/// <summary>Wikidata property (P2197) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		ProductionRate = 2197,

		/// <summary>Wikidata property (P2198) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		AverageGradient = 2198,

		/// <summary>Wikidata property (P2199) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		AutoignitionTemperature = 2199,

		/// <summary>Wikidata property (P2200) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		ElectricCharge = 2200,

		/// <summary>Wikidata property (P2201) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		DipoleMoment = 2201,

		/// <summary>Wikidata property (P2202) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		LowerFlammableLimit = 2202,

		/// <summary>Wikidata property (P2203) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		UpperFlammableLimit = 2203,

		/// <summary>Wikidata property (P2204) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MinimumExplosiveConcentration = 2204,

		/// <summary>Wikidata property (P2205) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SpotifyAlbumID = 2205,

		/// <summary>Wikidata property (P2206) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DiscogsReleaseID = 2206,

		/// <summary>Wikidata property (P2207) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SpotifyTrackID = 2207,

		/// <summary>Wikidata property (P2208) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		AverageShotLength = 2208,

		/// <summary>Wikidata property (P2209) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		SourceForgeProject = 2209,

		/// <summary>Wikidata property (P2210) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		RelativeTo = 2210,

		/// <summary>Wikidata property (P2211) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		PositionAngle = 2211,

		/// <summary>Wikidata property (P2212) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		AngularDistance = 2212,

		/// <summary>Wikidata property (P2213) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		LongitudeOfAscendingNode = 2213,

		/// <summary>Wikidata property (P2214) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Parallax = 2214,

		/// <summary>Wikidata property (P2215) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		ProperMotion = 2215,

		/// <summary>Wikidata property (P2216) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		RadialVelocity = 2216,

		/// <summary>Wikidata property (P2217) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		CruiseSpeed = 2217,

		/// <summary>Wikidata property (P2218) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		NetWorth = 2218,

		/// <summary>Wikidata property (P2219) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		RealGrossDomesticProductGrowthRate = 2219,

		/// <summary>Wikidata property (P2220) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		HouseholdWealth = 2220,

		/// <summary>Wikidata property (P2221) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Flux = 2221,

		/// <summary>Wikidata property (P2222) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		GyromagneticRatio = 2222,

		/// <summary>Wikidata property (P2223) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		DecayWidth = 2223,

		/// <summary>Wikidata property (P2224) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		SpectralLine = 2224,

		/// <summary>Wikidata property (P2225) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Discharge = 2225,

		/// <summary>Wikidata property (P2226) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MarketCapitalization = 2226,

		/// <summary>Wikidata property (P2227) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Metallicity = 2227,

		/// <summary>Wikidata property (P2228) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MaximumThrust = 2228,

		/// <summary>Wikidata property (P2229) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MaxTDP = 2229,

		/// <summary>Wikidata property (P2230) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Torque = 2230,

		/// <summary>Wikidata property (P2231) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		ExplosiveVelocity = 2231,

		/// <summary>Wikidata property (P2232) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Cash = 2232,

		/// <summary>Wikidata property (P2233) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		SemiMajorAxis = 2233,

		/// <summary>Wikidata property (P2234) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		VolumeForQuantity = 2234,

		/// <summary>Wikidata property (P2235) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		ExternalSuperproperty = 2235,

		/// <summary>Wikidata property (P2236) of <see cref="DataType.Url"/></summary>
		[Type(DataType.Url)]
		ExternalSubproperty = 2236,

		/// <summary>Wikidata property (P2237) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		UnitsUsedForThisProperty = 2237,

		/// <summary>Wikidata property (P2238) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		OfficialSymbol = 2238,

		/// <summary>Wikidata property (P2239) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		FirstAidMeasures = 2239,

		/// <summary>Wikidata property (P2240) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MedianLethalDose = 2240,

		/// <summary>Wikidata property (P2241) of <see cref="DataType.Item"/></summary>
		[Type(DataType.Item)]
		ReasonForDeprecation = 2241,

		/// <summary>Wikidata property (P2242) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FlorentineMuseaCatalogueID = 2242,

		/// <summary>Wikidata property (P2243) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Apoapsis = 2243,

		/// <summary>Wikidata property (P2244) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Periapsis = 2244,

		/// <summary>Wikidata property (P2248) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		ArgumentOfPeriapsis = 2248,

		/// <summary>Wikidata property (P2249) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		RefseqGenomeID = 2249,

		/// <summary>Wikidata property (P2250) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		LifeExpectancy = 2250,

		/// <summary>Wikidata property (P2252) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		NGAArtistId = 2252,

		/// <summary>Wikidata property (P2253) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DfEURN = 2253,

		/// <summary>Wikidata property (P2254) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		MaximumOperatingAltitude = 2254,

		/// <summary>Wikidata property (P2255) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		DebrettsPeopleOfTodayID = 2255,

		/// <summary>Wikidata property (P2257) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		FrequencyOfEvent = 2257,

		/// <summary>Wikidata property (P2258) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MobileCountryCode = 2258,

		/// <summary>Wikidata property (P2259) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ITUTNetworkIdentifier = 2259,

		/// <summary>Wikidata property (P2260) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		IonizationEnergy = 2260,

		/// <summary>Wikidata property (P2261) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Beam = 2261,

		/// <summary>Wikidata property (P2262) of <see cref="DataType.Quantity"/></summary>
		[Type(DataType.Quantity)]
		Draft = 2262,

		/// <summary>Wikidata property (P2263) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		ISOCATId = 2263,

		/// <summary>Wikidata property (P2264) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		MixnmatchCatalogueID = 2264,

		/// <summary>Wikidata property (P2266) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		FashionModelDirectoryID = 2266,

		/// <summary>Wikidata property (P2267) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		PolitifactPersonalityIdentifier = 2267,

		/// <summary>Wikidata property (P2268) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		OrsayMuseumArtistID = 2268,

		/// <summary>Wikidata property (P2270) of <see cref="DataType.String"/></summary>
		[Type(DataType.String)]
		EmporisBuildingComplexID = 2270,

		/// <summary>Wikidata property (P2271) of <see cref="DataType.Property"/></summary>
		[Type(DataType.Property)]
		WikidataPropertySample = 2271,
	}
}