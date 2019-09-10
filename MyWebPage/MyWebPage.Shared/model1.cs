// This file was automatically generated by VS extension Windows Machine Learning Code Generator v3
// from model file model1.onnx
// Warning: This file may get overwritten if you add add an onnx file with the same name
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Media;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.AI.MachineLearning;
namespace MyWebPage.Shared
{
    
    public sealed class model1Input
    {
        public TensorFloat dense_1_input; // shape(-1,784)
    }
    
    public sealed class model1Output
    {
        public TensorFloat activation_10Softmax00; // shape(-1,10)
    }
    
    public sealed class model1Model
    {
        private LearningModel model;
        private LearningModelSession session;
        private LearningModelBinding binding;
        public static async Task<model1Model> CreateFromStreamAsync(IRandomAccessStreamReference stream)
        {
            model1Model learningModel = new model1Model();
            learningModel.model = await LearningModel.LoadFromStreamAsync(stream);
            learningModel.session = new LearningModelSession(learningModel.model);
            learningModel.binding = new LearningModelBinding(learningModel.session);
            return learningModel;
        }
        public async Task<model1Output> EvaluateAsync(model1Input input)
        {
            binding.Bind("dense_1_input", input.dense_1_input);
            var result = await session.EvaluateAsync(binding, "0");
            var output = new model1Output();
            output.activation_10Softmax00 = result.Outputs["activation_1/Softmax:0"] as TensorFloat;
            return output;
        }
    }
}

