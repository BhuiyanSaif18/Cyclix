import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { CycleBrand } from 'src/models/CycleBrand';
import { CycleType } from 'src/models/CycleType';

@Injectable({
  providedIn: 'root',
})
export class StepperService {
  constructor() {}

  getBrands() : Observable<CycleBrand[]> {
    return of(
      [
        { name: 'Trek' }, 
        { name: 'BMC' },
        { name: 'Scott' }
      ]);
  }
  getBikeType(): Observable<CycleType[]> {
    return of(
      [
        { name: 'Rennvelo' }, 
        { name: 'Reisevelo' },
        { name: 'Elektro Velo' }
      ]);
  }
}
