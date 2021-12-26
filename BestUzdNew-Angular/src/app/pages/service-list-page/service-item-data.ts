export class ServiceItemData {
    constructor(
        public title: string,
        public description: string,
        public active: boolean,
        public url: string,
        public childs: ChildServiceItemData[] = []
    ) { }
}

export class ChildServiceItemData {
    constructor(
        public title: string,
        public price: number,
        public url: string,
    ) { }
}