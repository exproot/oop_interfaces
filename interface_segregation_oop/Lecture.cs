using System;

namespace interface_segregation_oop {
    public class Lecture : IResearchAssistance {
        public void Lecturing() {
            throw new NotImplementedException();
        }

        public void Researching() {
            throw new NotImplementedException();
        }
    }
}
