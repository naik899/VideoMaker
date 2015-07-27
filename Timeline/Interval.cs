// Copyright 2006-2008 Splicer Project - http://www.codeplex.com/splicer/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Splicer.Timeline
{
    public class Interval
    {
        public Interval()
        {
        }

        public Interval(double time, string value)
            : this(IntervalMode.Interpolate, time, value)
        {
        }

        public Interval(IntervalMode mode, double time, string value)
        {
            Mode = mode;
            Time = time;
            Value = value;
        }

        public IntervalMode Mode { get; set; }

        public double Time { get; set; }

        public string Value { get; set; }
    }
}