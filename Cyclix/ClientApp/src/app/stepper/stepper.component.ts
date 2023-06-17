import {Component, OnInit, ViewChild} from '@angular/core';
import {FormBuilder, FormGroup, Validators} from '@angular/forms';
import {BreakpointObserver} from '@angular/cdk/layout';
import {MatStepper, StepperOrientation} from '@angular/material/stepper';
import {Observable} from 'rxjs';
import {map} from 'rxjs/operators';

@Component({
  selector: 'app-stepper',
  templateUrl: './stepper.component.html',
  styleUrls: ['./stepper.component.css']
})
export class StepperComponent implements OnInit{
  @ViewChild(MatStepper) stepper!: MatStepper;

  cycleInfoFormGroup!: FormGroup;
  servicePricingFormGroup!: FormGroup;
  individualPartServiceFormGroup!: FormGroup;
  cycleProblemDetailFormGroup!: FormGroup;
  addressFormGroup!: FormGroup;

  constructor(private formBuilder: FormBuilder) { }

  clickNext(): void {
    this.stepper.next();
  }

  ngOnInit(): void {
    this.cycleInfoFormGroup = this.formBuilder.group({
      cycleType: [''],
      brandName: [''],
    });

    this.servicePricingFormGroup = this.formBuilder.group({
      servicePricingOption: [''],
      skipServicePackage: [false],
      isElectricCycle: [false],
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
      moreDetailedIssue: [''],
      costEstimate: ['']
    });

    this.addressFormGroup = this.formBuilder.group({
      firstName: [''],
      lastName: [''],
      street: [''],
      nr: [''],
      city: [''],
      zipCode: [''],
      email: ['',  [Validators.required, Validators.email]],
      phone: ['']
    });

  }

  onSubmit(): void {
    if (this.cycleInfoFormGroup.valid && 
      this.servicePricingFormGroup.valid &&
      this.individualPartServiceFormGroup.valid &&
      this.cycleProblemDetailFormGroup.valid &&
      this.addressFormGroup.valid) {
      console.log('Form submitted!');
      console.log('cycleInfoFormGroup values:', this.cycleInfoFormGroup.value);
      console.log('servicePricingFormGroup values:', this.servicePricingFormGroup.value);
      console.log('individualPartServiceFormGroup values:', this.individualPartServiceFormGroup.value);
      console.log('cycleProblemDetailFormGroup values:', this.cycleProblemDetailFormGroup.value);
      console.log('Address form values:', this.addressFormGroup.value);
    }
  }
}
