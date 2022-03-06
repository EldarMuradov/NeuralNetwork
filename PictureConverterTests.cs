using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeuralNetworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks.Tests
{
    [TestClass()]
    public class PictureConverterTests
    {
        [TestMethod()]
        public void ConvertTest()
        {
            var converter = new PictureConverter();
            var inputs = converter.Convert(@"E:\vs_projects\NeuralNetwork\neuralnetworks-master\NeuralNetworksTests\Images\Parasitized.png");
            converter.Save("E:\\image.png", inputs);
        }
    }
}