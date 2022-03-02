
export class WorkingPlaceDto {
    constructor(public title: string,
        public workingTime1: string,
        public workingTime2: string,
        public phoneNumbers: string[] = [],
        public contactorName: string,
        public address: string,
        public map: string) {
    }
}

export const clinics: WorkingPlaceDto[] = [
   new WorkingPlaceDto("УЗД Кабінет", "Будні: з 9 до 16", "Вихідні: під запис", [
    "+38 (096) 321-88-88",
    "+38 (063) 189-18-88",
    "+38 (095) 883-28-28"
   ], "Юлія Володимірівна", "Київ, Проспект Правди, 64а",
   "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2537.5675748750614!2d30.42987301589748!3d50.50500539131311!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40d4cd7a566a1661%3A0xe46d0d9df545bfb9!2z0L_RgNC-0YHQvy4g0J_RgNCw0LLQtNGLLCA2NNCQLCDQmtC40LXQsiwgMDIwMDA!5e0!3m2!1sru!2sua!4v1643735372223!5m2!1sru!2sua"
   ),
   new WorkingPlaceDto("Клініка", "Будні: під запис", "Вихідні: під запис", [
    "+38 (096) 321-88-88",
    "+38 (063) 189-18-88",
    "+38 (095) 883-28-28"
   ], "Юлія Володимірівна", "Київ, Проспект Правди, 62",
   "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d20309.05298206138!2d30.47212329620466!3d50.48520128589141!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40d4cd6689a3954f%3A0x4d482f455597784f!2z0JrQu9GW0L3RltC60LAg0LTQu9GPINCy0YHRltGU0Zcg0YDQvtC00LjQvdC4!5e0!3m2!1sru!2sua!4v1643735136290!5m2!1sru!2sua"
   ),
]
