import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatStepper } from '@angular/material/stepper';
import { Subscription } from 'rxjs';
import { StepperService } from './stepper.service';
import { RepairRequestModel } from 'src/models/RepairRequestMode';
import { CycleType } from 'src/models/CycleType';

@Component({
  selector: 'app-stepper',
  templateUrl: './stepper.component.html',
  styleUrls: ['./stepper.component.css'],
})
export class StepperComponent implements OnInit {
  @ViewChild(MatStepper) stepper!: MatStepper;

  cycleTypeOptions : string[] = [];
  brandOptions : string[] = [];
  cycleInfoFormGroup!: FormGroup;
  servicePricingFormGroup!: FormGroup;
  individualPartServiceFormGroup!: FormGroup;
  cycleProblemDetailFormGroup!: FormGroup;
  addressFormGroup!: FormGroup;

  subscriptions: Subscription[] = [];

  constructor(
    private formBuilder: FormBuilder,
    private stepperService: StepperService
  ) {}

  clickNext(): void {
    this.stepper.next();
  }

  ngOnInit(): void {
    this.getBikeType();
    this.getBikeBrands();
    this.cycleInfoFormGroup = this.formBuilder.group({
      cycleType: ['', [Validators.required]],
      brandName: ['', [Validators.required]],
    });

    this.servicePricingFormGroup = this.formBuilder.group({
      servicePricingOption: [''],
      skipServicePackage: [false],
      isElectricCycle: [false, [Validators.required]],
    });

    this.individualPartServiceFormGroup = this.formBuilder.group({
      tubeOrTire: [false],
      wheelCentering: [false],
      adjustingGears: [false],
      adjectBreaks: [false],
      changeBreakPads: [false],
      suspension: [false],
      damper: [false],
      completeCleaning: [false],
      lightCheck: [false],
      functionCheck: [false],
      batteryCheck: [false],
    });

    this.cycleProblemDetailFormGroup = this.formBuilder.group({
      moreDetailedIssue: ['',[Validators.required]],
      estimatedCost: ['', [Validators.required]],
    });

    this.addressFormGroup = this.formBuilder.group({
      firstName: ['',[Validators.required]],
      lastName: ['',[Validators.required]],
      street: [''],
      nr: [''],
      city: [''],
      zipCode: [''],
      email: ['', [Validators.required, Validators.email]],
      phone: ['', [Validators.required]],
    });
  }
  getBikeBrands() {
    const sub = this.stepperService.getBrands().subscribe((x) => {
      this.brandOptions = x.map((x) => x.name);
    });
    this.subscriptions.push(sub);
  }
  getBikeType() {
    const sub = this.stepperService.getBikeType().subscribe((x) => {
      this.cycleTypeOptions = x.map((x) => x.name);
    });
    this.subscriptions.push(sub);
  }

  onSubmit(): void {
    if (
      this.cycleInfoFormGroup.valid &&
      this.servicePricingFormGroup.valid &&
      this.individualPartServiceFormGroup.valid &&
      this.cycleProblemDetailFormGroup.valid &&
      this.addressFormGroup.valid
    ) {
      console.log('Form submitted!');
      console.log('cycleInfoFormGroup values:', this.cycleInfoFormGroup.value);
      console.log(
        'servicePricingFormGroup values:',
        this.servicePricingFormGroup.value
      );
      console.log(
        'individualPartServiceFormGroup values:',
        this.individualPartServiceFormGroup.value
      );
      console.log(
        'cycleProblemDetailFormGroup values:',
        this.cycleProblemDetailFormGroup.value
      );
      console.log('Address form values:', this.addressFormGroup.value);
      let repairRequestModel : RepairRequestModel = {...this.cycleInfoFormGroup.value,
        ...this.servicePricingFormGroup.value,
        ...this.individualPartServiceFormGroup.value,
        ...this.cycleProblemDetailFormGroup.value,
        ...this.addressFormGroup.value
      }
      const sub = this.stepperService.saveRepairRequest(repairRequestModel).subscribe((x) => {
        console.log(x);
      });
      this.subscriptions.push(sub);
    }
  }
  ngOnDestroy(): void {
    for (const subscription of this.subscriptions) {
      subscription.unsubscribe();
    }
  }
}
