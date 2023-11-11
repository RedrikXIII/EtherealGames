export class SliderCard
{
    static AddClick(component, slide) {
        slide.addEventListener("click", () => { component.invokeMethodAsync("Click") });
    }

    static SetTimeout(component, slide) {
        let mousenter = false;
        let timeout = false;

        function MouseEnter() {
            mousenter = true;
        }

        function MouseLeave() {
            mousenter = false;
            if (timeout) {
                Next();
            }
        }

        function Next() {
            slide.removeEventListener("mouseleave", MouseLeave);
            slide.removeEventListener("mouseenter", MouseEnter);
            component.invokeMethodAsync("Next");
        }

        slide.addEventListener("mouseenter", MouseEnter)
        slide.addEventListener("mouseleave", MouseLeave)

        setTimeout(() => {
            timeout = true;
            console.log(1);
            if (!mousenter) {
                Next();
            }
        }, 5000)
    }
}