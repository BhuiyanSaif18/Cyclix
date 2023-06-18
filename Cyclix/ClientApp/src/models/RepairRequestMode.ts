export interface RepairRequestModel {
    cycleType: string;
    brandName: string;
    servicePricingOption: string;
    skipServicePackage: boolean;
    isElectricCycle: boolean;
    tubeOrTire: boolean;
    wheelCentering: boolean;
    adjustingGears: boolean;
    adjectBreaks: boolean;
    changeBreakPads: boolean;
    suspension: boolean;
    completeCleaning: boolean;
    lightCheck: boolean;
    functionCheck: boolean;
    batteryCheck: boolean;
    moreDetailedIssue: string;
    estimatedCost: number;
    firstName: string;
    lastName: string;
    street: string;
    nr: string;
    city: string;
    zipCode: string;
    email: string;
    phone: string;
  }