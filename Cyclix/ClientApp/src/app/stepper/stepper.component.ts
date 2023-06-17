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

  formGroup!: FormGroup;
  addressFormGroup!: FormGroup;

  constructor(private formBuilder: FormBuilder) { }

  clickNext(): void {
    this.stepper.next();
  }

  ngOnInit(): void {
    this.formGroup = this.formBuilder.group({
      dropdown1: [''],
      dropdown2: [''],
      radioOption: [''],
      checkbox1: [false],
      checkbox2: [false],
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
    if (this.formGroup.valid && this.addressFormGroup.valid) {
      console.log('Form submitted!');
      console.log('Form values:', this.formGroup.value);
      console.log('Address form values:', this.addressFormGroup.value);
    }
  }
}
