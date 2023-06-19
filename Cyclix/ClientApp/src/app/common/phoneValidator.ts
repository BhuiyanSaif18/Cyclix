import { AbstractControl, ValidatorFn } from '@angular/forms';

export function phoneValidator(): ValidatorFn {
  const phonePattern = /^[0-9]{10}$/;

  return (control: AbstractControl): { [key: string]: any } | null => {
    const value = control.value;

    if (value && !phonePattern.test(value)) {
      return { phone: true };
    }

    return null;
  };
}