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
      dropdown1: [''],
      dropdown2: [''],
    });

    this.servicePricingFormGroup = this.formBuilder.group({
      radioOption: [''],
      checkbox1: [false],
      checkbox2: [false],
    });

    this.individualPartServiceFormGroup = this.formBuilder.group({
      checkbox3: [false],
      checkbox4: [false],
      checkbox5: [false],
      checkbox6: [false],
      checkbox7: [false],
      checkbox8: [false],
      checkbox9: [false],
      checkbox10: [false],
      checkbox11: [false],
      checkbox12: [false],
      checkbox13: [false],
      checkbox14: [false],
    });

    this.cycleProblemDetailFormGroup = this.formBuilder.group({
      textInput1: [''],
      textInput2: ['']
    });

    this.addressFormGroup = this.formBuilder.group({
      addressLine1: [''],
      addressLine2: [''],
      city: [''],
      state: [''],
      zipCode: [''],
      country: [''],
      phone: [''],
      email: ['', [Validators.required, Validators.email]]
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
